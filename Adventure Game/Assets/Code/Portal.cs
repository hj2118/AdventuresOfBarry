using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public GameObject particles;
    public GameObject portal;
    
    void Start()
    {
        particles.SetActive(false);
    }

    void Update()
    {
        if(PublicVars.hasAllFlowers == true){
            particles.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if (PublicVars.hasAllFlowers){
<<<<<<< HEAD
                SceneManager.LoadScene("Level 5");
=======
                SceneManager.LoadScene("Game Over");
>>>>>>> parent of fe6c4a8 (check)
            }
        }
    }
}
