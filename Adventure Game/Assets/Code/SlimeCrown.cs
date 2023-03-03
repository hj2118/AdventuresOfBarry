using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeCrown : MonoBehaviour
{
    public string levelToLoad;
    public GameObject newSprite;
    public GameObject oldSprite;

    void Start(){
        newSprite.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(PublicVars.hasCrown){
                oldSprite.SetActive(false);
                newSprite.SetActive(true);
                Invoke("Load", 3f);
            }
        }
    }

    private void Load(){
        SceneManager.LoadScene(levelToLoad);
    }
}
