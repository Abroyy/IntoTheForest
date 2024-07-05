using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuLose : MonoBehaviour
{

    public AudioSource audioSource;

    void Start()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            audioSource.Play();
        }
    }
}
