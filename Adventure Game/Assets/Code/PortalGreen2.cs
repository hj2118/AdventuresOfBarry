using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGreen2 : MonoBehaviour
{

    public GameObject Player;
    Vector3 newPos = new Vector3(-0.67f, 44.194f, 12.49f);

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            Player.GetComponent<UnityEngine.AI.NavMeshAgent>().ResetPath();
            Player.transform.position = newPos;
            print("hit");
            Invoke("StartNavMesh", 1f);
        }
    }

    private void StartNavMesh(){
        Player.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
    }
}
