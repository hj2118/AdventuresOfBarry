using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerVillage : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    Camera mainCam;
    private int flowers = 0;
    GameManager _gameManager;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _gameManager = FindObjectOfType<GameManager>();
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
        if(other.CompareTag("Flower")){
            Destroy(other.gameObject);
            flowers += 1;
            if(flowers == 7){
                PublicVars.hasAllFlowers = true;
            }
        }
        if (other.CompareTag("Enemy")){
            _gameManager.DecrementLives();
            Destroy(other.gameObject);
        }
    }
}
