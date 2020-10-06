using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyspraxibotController : MonoBehaviour
{
    private readonly float speed = 6.0f;
    private CharacterController controller;
    public float rotationRate = 360;
    
    void Start()
    {
        HandleMovement();
      //  GetComponent<Collider>().isTrigger = false;
    }
    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {

        controller = GetComponent<CharacterController>();

        if (Input.GetKey(KeyCode.W))
        {
            Vertical();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vertical();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Horizontal();

        }
        if (Input.GetKey(KeyCode.D))
        {
            Horizontal();
        }
    }
    private void Horizontal()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * speed);

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    private void Vertical()
    {
        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

}
    
    
