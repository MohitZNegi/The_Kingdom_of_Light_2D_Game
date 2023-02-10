using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_movement : MonoBehaviour
{
    
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
   
    private bool movingdown;
    private float downpoint;
    private float uppoint;

    private void Awake()
    {
        downpoint = transform.position.y - movementDistance;
        uppoint = transform.position.y + movementDistance;
    }

    private void Update()
    {
        if (movingdown)
        {
            if (transform.position.y > downpoint)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y- speed * Time.deltaTime, transform.position.z);
            }
            else
                movingdown = false;
        }
        else
        {
            if (transform.position.y < uppoint)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + speed * Time.deltaTime, transform.position.z);
            }
            else
                movingdown = true;
        }
    }

   
}

