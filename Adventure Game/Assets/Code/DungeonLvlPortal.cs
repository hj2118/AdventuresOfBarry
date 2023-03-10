using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonLvlPortal : MonoBehaviour
{
    public string levelToLoad;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player") && PublicVars.hasKey){
            PublicVars.hasKey = false;
            Invoke("Load", 1f);
        }
    }

    private void Load(){
        SceneManager.LoadScene(levelToLoad);
    }
}
