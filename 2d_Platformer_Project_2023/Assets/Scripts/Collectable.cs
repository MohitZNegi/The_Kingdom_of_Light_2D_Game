using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    public static Collectable instance;
    public TextMeshProUGUI text;
 
    public int score;
    // Start is called before the first frame update
    void Start()
    {
       
        if(instance == null)
        {
            instance = this;
        }
    }

   public void ChangeScore(int gemValue)
    {
        score += gemValue;
        text.text = score.ToString() + "/50";

       
    }

    
}
