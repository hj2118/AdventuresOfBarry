using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    GameObject player;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(ChasePlayer());
    }

    IEnumerator ChasePlayer() {
        while (true) {
            yield return new WaitForSeconds(1);
            _navMeshAgent.destination = player.transform.position;
        }
    }
}
