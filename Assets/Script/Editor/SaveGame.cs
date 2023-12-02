using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveGame : EditorWindow
{
    [MenuItem("Window/Delete All Save")]
    static void DeleteAllSave(){
        PlayerPrefs.DeleteAll();
    }
}
