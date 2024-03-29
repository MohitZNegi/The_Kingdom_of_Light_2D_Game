using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Finish_Point : MonoBehaviour
{
     [SerializeField] private AudioClip Level_completed;
       [SerializeField] private GameObject bgsound;
       [SerializeField] private GameObject info;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Collectable.instance.score == 50 &&  collision.tag == "Knight"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SoundEff_Manager.instance.PlaySound(Level_completed);
            bgsound.SetActive(false);
            
          
        }
        else if(Collectable.instance.score != 50 &&  collision.tag == "Knight"){
          info.SetActive(true);
        }

        
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
