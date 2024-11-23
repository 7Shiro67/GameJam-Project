using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isPaused = false;
    // Start is called before the first frame update
    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame();
            PauseMenu.SetActive(true);
        }
    }
    public void pauseGame()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
        }
    }
}
