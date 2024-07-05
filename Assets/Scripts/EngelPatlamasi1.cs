using System.Collections;
using UnityEngine;

public class EngelPatlamasi1 : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public float explosionDuration = 1.5f;

    void Start()
    {
        explosionEffect.Stop();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            // 2 saniye sonra Parcalanma metodu �a�r�l�r
            Invoke("Parcalanma", explosionDuration);
        }
    }

    private void PlayExplosionEffect()
    {
        // Patlama efektini ba�lat
        if (explosionEffect != null)
        {
            explosionEffect.Play();
        }
    }

    private void Parcalanma()
    {
        // Patlama efektini ba�lat
        PlayExplosionEffect();

        // Engelin collider'�n� kapat
        GetComponent<Collider2D>().enabled = false;


        GetComponent<SpriteRenderer>().enabled = false;
    }

    
}
