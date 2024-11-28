using JetBrains.Annotations;
using NodeCanvas.Tasks.Conditions;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class Gamedata
{
    public Vector3 playerPosition;
    public List<bool> isactive;

}


public class SaveSystem : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public GameObject player;
    public GameObject LoadDataPanel;
    void Start()
    {
        
    }
    // Start is called before the first frame update
    public void SaveGame(Gamedata gamedata)
    {
        string filePath = Path.Combine(Application.persistentDataPath, "savegame.json");
        string json = JsonUtility.ToJson(gamedata);
        File.WriteAllText(filePath, json);
    }
    public Gamedata LoadGame()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "savegame.json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            Gamedata gamedata = JsonUtility.FromJson<Gamedata>(json);
            return gamedata;
        }
        else
        {
            return null;
        }
    }
    
    public void ButtonSaveGame()
    {
        Gamedata gamedata = new Gamedata
        {
            isactive = Isactive(),
            playerPosition = player.transform.position,
        };
        SaveGame(gamedata);
    }
    public void ButtonLoadGame()
    {
        Gamedata gamedata = LoadGame();
        if (gamedata != null)
        {
            player.transform.position = gamedata.playerPosition;
            for (int i = 0; i < gameObjects.Count; i++)
            {
                if (i < gamedata.isactive.Count)
                {
                    gameObjects[i].SetActive(gamedata.isactive[i]);
                }
            }
        }
        LoadDataPanel.SetActive(false);
    }
    List<bool> Isactive()
    {
        List<bool> list = new();
        foreach (GameObject go in gameObjects)
        {
            bool isActive = go.activeSelf;
            list.Add(isActive);
        }
        return list;
    }

}



