using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home()
    {
        #if !UNITY_WEBGL
        Application.Quit();
        #endif
        # if UNITY_WEBGL
        SceneManager.LoadScene("Welcome");
        #endif

    }
}
