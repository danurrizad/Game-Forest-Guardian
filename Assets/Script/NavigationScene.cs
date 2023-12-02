using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;
using UnityEngine.UI;

public class NavigationScene : MonoBehaviour
{
    // [SerializeField] private string SceneTarget;
    // [SerializeField] private string sceneName;
    private void Start() {

    }

    public static void LoadToScene(string sceneName){
        // SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene(sceneName);

    }

    
}
