using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject target;
    public float speed = 5;

    Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        // Look
        var newRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, speed * Time.deltaTime);

        // Move
        Vector3 newPosition = target.transform.position - (target.transform.forward*-1) * offset.z - target.transform.up * offset.y;
        transform.position = Vector3.Slerp(transform.position, newPosition, Time.deltaTime * speed);
    }
    // public GameObject target;
    // public float damping = 1;
    // Vector3 offset;
    // void Start() {
    //     offset = transform.position - target.transform.position;
    // }
    
    // void LateUpdate() {
    //     Vector3 desiredPosition = target.transform.position + offset;
    //     Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
    //     transform.position = position;
    //     transform.LookAt(target.transform.position);
    // }
}