using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float rspeed = 100f;
    CharacterController controller;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = Vector3.forward * moveZ + Vector3.right * moveX;
        controller.Move(move * speed * Time.deltaTime);
        float rotate = Input.GetAxis("Mouse X") * rspeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
        

    }
}