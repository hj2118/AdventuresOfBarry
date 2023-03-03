using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowClassroom : MonoBehaviour
{
    GameObject player;
    Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }
    private void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}

