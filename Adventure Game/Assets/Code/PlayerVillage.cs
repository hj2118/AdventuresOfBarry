using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerVillage : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    Camera mainCam;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                _navMeshAgent.destination = hit.point;
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Crown")){
            Destroy(other.gameObject);
            PublicVars.hasCrown = true;
        }
        if(other.CompareTag("Helmet")){
            Destroy(other.gameObject);
            PublicVars.hasHelmet = true;
        }
        if(other.CompareTag("Leaf")){
            Destroy(other.gameObject);
            PublicVars.hasLeaf = true;
        }
        if(other.CompareTag("Wood")){
            Destroy(other.gameObject);
            PublicVars.hasWood = true;
        }
    }
}
