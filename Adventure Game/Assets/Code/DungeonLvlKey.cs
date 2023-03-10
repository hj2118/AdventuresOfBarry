using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonLvlKey : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            PublicVars.hasKey = true;
            Destroy(gameObject);
        }
    }
}
