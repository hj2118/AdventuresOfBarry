using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGreen2 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(-0.67f, 44.194f, 12.49f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
