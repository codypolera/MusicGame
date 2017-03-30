using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalSound1 : MonoBehaviour
{
    public AudioClip sound;

    private AudioSource source;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        source.PlayOneShot(sound, 1F);
    }

}
