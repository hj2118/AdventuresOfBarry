using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    GameManager _gameManager;
    public AudioClip clip;
    public AudioSource source;
    void Start(){
        _gameManager = FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            source.PlayOneShot(clip);
            Destroy(gameObject);
            _gameManager.IncrementItemCounter();
        }
    }
}
