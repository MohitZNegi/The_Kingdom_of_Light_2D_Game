using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollectable : MonoBehaviour
{
     [SerializeField] private float healthValue;
    [SerializeField] private AudioClip heartcollect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Knight")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
            SoundEff_Manager.instance.PlaySound(heartcollect);
        }
    }
}