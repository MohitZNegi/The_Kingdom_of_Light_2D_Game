using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
 
       [SerializeField] private GameObject info;


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.tag == "Knight"){
          info.SetActive(false);
        }

        
     
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
