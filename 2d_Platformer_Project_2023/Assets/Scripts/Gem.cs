using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private AudioClip GemCollect;
    public int gemValue = 1;
   private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Knight"))
        Collectable.instance.ChangeScore(gemValue);
        SoundEff_Manager.instance.PlaySound(GemCollect);
    }

}
