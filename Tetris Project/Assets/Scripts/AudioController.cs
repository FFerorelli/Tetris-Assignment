using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoSingleton<AudioController>
{
    public AudioSource Theme;
    public void PlayThemeMusic()
    {
        Theme.loop = true;
        Theme.Play();
    }
    public void StopThemeMusic()
    {
        Theme.loop = false;
        Theme.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
