using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip zag;
    public AudioClip click;
    public AudioClip BGM;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SXF(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }
}
