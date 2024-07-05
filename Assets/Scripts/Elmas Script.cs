using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ElmasScript : MonoBehaviour
{
    
    public bool toplandi = false;
    public int puanArtisMiktari = 1;
    public TextMeshProUGUI puanText;
    public AudioSource audioSource;
    public SpriteRenderer elmas;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character") && !toplandi)
        {
            
            elmas.enabled = false;
            toplandi = true;
            audioSource.Play();
            GuncelPuaniArttir(puanArtisMiktari);

            StartCoroutine(PlayAudio());
        }
    }

    private IEnumerator PlayAudio()
    {

        yield return new WaitForSeconds(audioSource.clip.length);

        Destroy(gameObject);
        
    }

    private void GuncelPuaniArttir(int artisMiktari)
    {
        int mevcutPuan = int.Parse(puanText.text);
        int yeniPuan = mevcutPuan + artisMiktari;
        puanText.text = yeniPuan.ToString();
    }
}
