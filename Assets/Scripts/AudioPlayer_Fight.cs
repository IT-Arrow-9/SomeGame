using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer_Fight : MonoBehaviour
{
    public List<AudioClip> music = new List<AudioClip>();
    public AudioSource sas;
    void Start()
    {
        sas = GetComponent<AudioSource>();
        sas.clip = music[Random.RandomRange(0, music.Count - 1)];
        sas.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
