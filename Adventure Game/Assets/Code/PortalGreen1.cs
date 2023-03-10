using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGreen1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    Vector3 newPos = new Vector3(-2.47f, 44.194f, 1.15f);


    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            print("hit");
            Player1.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            Player3.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player1.SetActive(true);
            Player3.SetActive(false);
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
