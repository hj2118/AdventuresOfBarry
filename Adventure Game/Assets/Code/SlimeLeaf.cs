using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeLeaf : MonoBehaviour
{
    public GameObject helmetPrefab;
    Vector3 vec = new Vector3(-23.98f, 2.44f, 172.182f);
    public GameObject newSprite;
    public GameObject oldSprite;

    void Start(){
        newSprite.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(PublicVars.hasLeaf){
                Instantiate(helmetPrefab, vec, Quaternion.identity);
                oldSprite.SetActive(false);
                newSprite.SetActive(true);
            }
        }
    }
}
