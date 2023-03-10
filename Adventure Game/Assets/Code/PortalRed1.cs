using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRed1 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(-2.39f, 44.194f, 11.91f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
