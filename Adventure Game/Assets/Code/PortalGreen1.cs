using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGreen1 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(-2.47f, 44.194f, 1.15f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
