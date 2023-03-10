using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRed1 : MonoBehaviour
{

    public GameObject Player;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    Vector3 newPos = new Vector3(-2.39f, 44.194f, 11.91f);


    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player2.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player3.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            Player2.SetActive(false);
            Player3.SetActive(true);
        }
    }

    // void OnTriggerEnter(Collider other){
    //     if (other.CompareTag("Player")){
    //         Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
    //         Player.GetComponent<UnityEngine.AI.NavMeshAgent>().ResetPath();
    //         Player.transform.position = newPos;
    //         print("hit");
    //         Invoke("StartNavMesh", 1f);
    //     }
    // }

    // private void StartNavMesh(){
    //     Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
    // }
}
