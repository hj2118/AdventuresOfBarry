using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPurple1 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(-1.586f, 44.194f, 8.428f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
            print("hit");
        }
    }
}
