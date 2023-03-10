using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player1;
    public GameObject Player4;
    Vector3 newPos = new Vector3(2.39f, 44.194f, 6.46f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player1.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player4.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            Player1.SetActive(false);
            Player4.SetActive(true);
        }
    }

    // void OnTriggerEnter(Collider other){
    //     if (other.CompareTag("Player")){
    //         Player.transform.position = newPos;
    //     }
    // }
}
