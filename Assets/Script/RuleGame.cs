using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuleGame : MonoBehaviour
{
    public Text winText;
    public Text levelSceneText;
    int levelNumber;

    public void Awake(){
        
    }
    private void Start() {
        GetLevelScene();
        // Debug.Log(winText);
    }

    public void GetLevelScene(){
        string stringLevelScene = levelSceneText.text;
        if (int.TryParse(stringLevelScene.Replace("Level ", ""), out levelNumber))
        {
            Debug.Log("Level Number: " + levelNumber);
        }
        else
        {
            Debug.LogError("Gagal mengubah string menjadi angka");
        }
    }

    public void UpdateLevel(){
        MainMenu.currentLevel = levelNumber;
        PlayerPrefs.SetInt("Level", MainMenu.currentLevel);
    }

    public void LoadToMenu(){
        NavigationScene.LoadToScene("Menu");
        MainMenu.instance.panelLevelSelect.SetActive(true);
        MainMenu.instance.CheckCurrentLevelProgress();
        // MainMenu.instance.ButtonPlay();
        Debug.Log("SAMPE DISINI LOG");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek apakah objek yang bersentuhan memiliki tag "Truck"
        if (collision.gameObject.CompareTag("Truck"))
        {
            // Implementasi kondisi menang
            Debug.Log("Anda menang!");

            // Menampilkan teks "Anda Menang" pada UI
            winText.text = "Anda Menang!";
            UpdateLevel();
            LoadToMenu();
            

            // Contoh: Menonaktifkan objek karakter atau komponen yang membuat pemain bisa bergerak
            // gameObject.SetActive(false);

            // Contoh: Memanggil fungsi untuk menyelesaikan level
            // LevelManager.CompleteLevel();
        }
    }
}