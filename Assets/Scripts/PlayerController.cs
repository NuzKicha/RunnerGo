using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController character;
    private int speed = 5;
    private int lineToMove = 1;
    private float lineDistance = 3;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        character.Move(Vector3.forward * Time.deltaTime * speed);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (lineToMove < 2)
            {
                lineToMove++;
            }

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (lineToMove > 0)
            {
                lineToMove--;
            }
        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (lineToMove == 0)
        {
            targetPosition += Vector3.left * lineDistance;
        }
        else if (lineToMove == 2)
        {
            targetPosition += Vector3.right * lineDistance;
        }

        transform.position = targetPosition;
    }
    
}
