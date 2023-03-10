using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPurple1 : MonoBehaviour
{

    public GameObject Player;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    Vector3 newPos = new Vector3(-1.586f, 44.194f, 8.428f);

    void Start(){
            Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            Player1.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player2.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player3.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player4.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player.SetActive(true);
            Player1.SetActive(false);
            Player2.SetActive(false);
            Player3.SetActive(false);
            Player4.SetActive(false);
    }


    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player2.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            Player.SetActive(false);
            Player2.SetActive(true);
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
