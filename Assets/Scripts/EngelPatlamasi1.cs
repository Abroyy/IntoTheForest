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
            // 2 saniye sonra Parcalanma metodu çaðrýlýr
            Invoke("Parcalanma", explosionDuration);
        }
    }

    private void PlayExplosionEffect()
    {
        // Patlama efektini baþlat
        if (explosionEffect != null)
        {
            explosionEffect.Play();
        }
    }

    private void Parcalanma()
    {
        // Patlama efektini baþlat
        PlayExplosionEffect();

        // Engelin collider'ýný kapat
        GetComponent<Collider2D>().enabled = false;


        GetComponent<SpriteRenderer>().enabled = false;
    }

    
}
