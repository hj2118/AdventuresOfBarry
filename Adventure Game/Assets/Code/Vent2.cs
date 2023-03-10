using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent2 : MonoBehaviour
{
    public GameObject Player;
    Vector3 newPos = new Vector3(1.02f, 44.194f, 1.07f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
