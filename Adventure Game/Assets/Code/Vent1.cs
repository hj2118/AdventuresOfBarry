using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent1 : MonoBehaviour
{
    public GameObject Player;
    Vector3 newPos = new Vector3(2.39f, 44.194f, 6.46f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.transform.position = newPos;
        }
    }
}
