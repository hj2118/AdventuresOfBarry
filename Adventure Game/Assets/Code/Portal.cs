using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject particles;
    
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
}
