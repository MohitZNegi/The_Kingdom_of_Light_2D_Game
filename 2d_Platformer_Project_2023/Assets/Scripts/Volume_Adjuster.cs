using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Volume_Adjuster : MonoBehaviour
{ 
    public AudioSource source;

    public Slider volumeSlider;

    public float bgsound = 1.0f;
    void Start()
    {
        source.Play();
        bgsound = PlayerPrefs.GetFloat("volume");
        source.volume = bgsound;
        volumeSlider.value = bgsound;

       
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = bgsound;
        PlayerPrefs.SetFloat("volume", bgsound);

       
        
    }

    void VolumerUpdater(float volume)
    {
        bgsound = volume;

    }
}
