using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerLibrary : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    Camera mainCam;
    GameManager _gameManager;
    private Vector3 respawn;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
        _gameManager = FindObjectOfType<GameManager>();
        respawn = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                _navMeshAgent.destination = hit.point;
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Book")){
            Destroy(other.gameObject);
            _gameManager.IncrementItemCounter();
        }

        if (other.CompareTag("Trap")){
            _gameManager.DecrementLives();
            transform.position = respawn;
            _navMeshAgent.destination = respawn;
        }
    }
}
