using Kinnly;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BottonLogicScript : MonoBehaviour
{
    public Text LocationName;

    public PauseGameScript pauseGameScript;
    // Start is called before the first frame update
    private void Start()
    {
        pauseGameScript = gameObject.GetComponent<PauseGameScript>();
    }
    public void backToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    public void continueGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void startGame()
    {

    }
    public void continueInGame()
    {
        pauseGameScript.pauseGame();
    }
    private bool LocationState = false;
    public void sceneChanger()
    {
        LocationState = !LocationState;
        if (LocationState)
        {
            LocationName.text = "ÃÎ¾³";
        }
        else
        {
            LocationName.text = "É¯ÃÎµÄ¼Ò";
        }
    }
}