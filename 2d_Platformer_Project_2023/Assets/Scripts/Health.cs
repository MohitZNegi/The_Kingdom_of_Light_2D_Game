using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   
    [SerializeField] private float startingHealth;
    [SerializeField] private AudioClip hurtsound;
    [SerializeField] private AudioClip deathSound;

   [SerializeField] private GameObject bgsound;

    [SerializeField] private GameObject gameover;

    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, 6);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            SoundEff_Manager.instance.PlaySound(hurtsound);
            //iframes
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                SoundEff_Manager.instance.PlaySound(deathSound);
                bgsound.SetActive(false);
                 gameover.SetActive(true);
                
            }
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, 6);
    }
}
