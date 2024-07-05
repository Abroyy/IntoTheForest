using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonKontrol2 : MonoBehaviour
{
    // Animator bile�eni
    private Animator animator;

    void Start()
    {
        // Animator bile�enini al
        animator = GetComponent<Animator>();
    }

    // Buton t�kland���nda �a�r�lan fonksiyon
    public void OnButonClick()
    {
        // Animasyonu ba�lat
        animator.SetTrigger("settingsanim");

        // Animasyonun uzunlu�unu al
        float animasyonSuresi = 0.5f;

        // Belirtilen s�re boyunca bekleyerek sahneye ge�i�i ger�ekle�tir
        Invoke("SahneyeGecis", animasyonSuresi);
    }

    // Sahneye ge�i�i sa�layan fonksiyon
    void SahneyeGecis()
    {
        // Yeni sahnenin ad�n� belirt
        string yeniSahneAdi = "Settings"; // De�i�tirmeniz gereken k�s�m

        // Belirtilen sahneye ge�i� yap
        SceneManager.LoadScene(yeniSahneAdi);
    }
}
