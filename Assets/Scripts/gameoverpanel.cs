using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverpanel : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("eventsystem"))
        {
           
        }
    }
}
