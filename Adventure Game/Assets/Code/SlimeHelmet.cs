using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeHelmet : MonoBehaviour
{
    public GameObject crownPrefab;
    Vector3 vec = new Vector3(-31.85f, 2.22f, 113.23f);
    public GameObject newSprite;
    public GameObject oldSprite;

    void Start(){
        newSprite.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(PublicVars.hasHelmet){
                Instantiate(crownPrefab, vec, Quaternion.identity);
                oldSprite.SetActive(false);
                newSprite.SetActive(true);
            }
        }
    }
}
