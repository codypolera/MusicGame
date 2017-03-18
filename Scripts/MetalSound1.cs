using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalSound1 : MonoBehaviour
{
    public AudioClip metalHit;

    private AudioSource source;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        source.PlayOneShot(metalHit, 1F);
    }

}
