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
                SceneManager.LoadScene("Level 4");
            }
        }
    }
}
