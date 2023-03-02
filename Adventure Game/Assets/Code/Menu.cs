using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager[] gameManagers = FindObjectsOfType<GameManager>();
        if (gameManagers.Length > 0){
            foreach (GameManager manager in gameManagers)
            {
                Destroy(manager);
            }
        }
        SceneManager.LoadScene("Level 1");
    }
    public void Resume(){
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
