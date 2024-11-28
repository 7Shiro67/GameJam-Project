using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public GameObject LoadDataPanel;
    public void NewGameButton()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "savegame.json");
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            LoadDataPanel.SetActive(false);
        }
        else
        {
            LoadDataPanel.SetActive(false);
        }
    }
}
