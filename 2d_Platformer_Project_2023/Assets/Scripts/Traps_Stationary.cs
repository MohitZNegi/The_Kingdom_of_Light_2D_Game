using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps_Stationary : MonoBehaviour

{ 
      [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Knight")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
