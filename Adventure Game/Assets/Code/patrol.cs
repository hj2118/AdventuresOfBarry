using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour {

    public Transform[] points;
    public GameObject player;
    private int destPoint = 0;
    private NavMeshAgent agent;
    GameManager _gameManager;
    public Transform playerRespawn;
    public AudioClip clip;
    public AudioSource source;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        _gameManager = FindObjectOfType<GameManager>();
        GotoNextPoint();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            source.PlayOneShot(clip);
            _gameManager.DecrementLives();
            player.transform.position = playerRespawn.position;
        }
    }
    void GotoNextPoint() {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update () {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}