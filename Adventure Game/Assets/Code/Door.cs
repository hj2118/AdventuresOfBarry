using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    GameManager _gameManager;
    void Start(){
        _gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            _gameManager.nextLevel();
        }
    }
}
