using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObject : MonoBehaviour
{

    public GameObject stick;
    public AudioClip swingSound;


    private float throwSpeed = 2000f;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    void Awake()
    {

        source = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(swingSound, vol);
            GameObject throwThis = Instantiate(stick, transform.position, transform.rotation) as GameObject;
            throwThis.rigidbody.AddRelativeForce(new Vector3(0, 0, throwSpeed));
        }

    }
}