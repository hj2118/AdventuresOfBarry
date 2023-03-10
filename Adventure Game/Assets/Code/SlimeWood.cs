using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeWood : MonoBehaviour
{
    public GameObject leafPrefab;
    Vector3 vec = new Vector3(-60.77f, 2.5f, 96.01f);

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(PublicVars.hasWood){
                Instantiate(leafPrefab, vec, Quaternion.identity);
            }
            PublicVars.hasWood = false;
        }
    }
}
