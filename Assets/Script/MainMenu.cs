using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject panelLevelSelect;

    [Header("Lock Level")] 
    public GameObject[] levels;
    public static int currentLevel;

    public static MainMenu instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogWarning("Warning gagal set instance");
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelToOne(){
        PlayerPrefs.SetInt("Level", 0);
        currentLevel = PlayerPrefs.GetInt("Level");
        Debug.Log("Reset level berhasil! Level : " + currentLevel);
        NavigationScene.LoadToScene("Menu");
        ButtonPlay();
    }

    public void CheckCurrentLevelProgress(){
        // int checkCurrentUpdate = PlayerPrefs.GetInt("Level");
        currentLevel = PlayerPrefs.GetInt("Level");
        Debug.Log("Current Level : " + currentLevel);
        Debug.Log("Length Level : " + levels.Length);
        if(currentLevel == levels.Length){
            PlayerPrefs.SetInt("Level", levels.Length - 1);
            currentLevel = PlayerPrefs.GetInt("Level");
        }
        
        for (int i = 0; i < currentLevel + 1; i++)
        {
            // unlock level
            levels[i].transform.GetChild(1).gameObject.SetActive(false); //disable the lock
            levels[i].transform.GetChild(0).gameObject.SetActive(true); //enable the text level
            levels[i].GetComponent<Button>().enabled = true; //activate button function
        }
    }
    public void ButtonPlay(){
        if(panelLevelSelect.activeInHierarchy==false){
            panelLevelSelect.SetActive(true);

            CheckCurrentLevelProgress();
        }
        else{
            panelLevelSelect.SetActive(false);
        }
    }
}
