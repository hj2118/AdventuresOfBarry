using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPurple2 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(2.84f, 44.194f, -0.44f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
