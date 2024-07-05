using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonKontrol3 : MonoBehaviour
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
        animator.SetTrigger("quitanim");

        // Animasyonun uzunlu�unu al
        float animasyonSuresi = 0.3f;

        // Belirtilen s�re boyunca bekleyerek sahneye ge�i�i ger�ekle�tir
        Invoke("SahneyeGecis", animasyonSuresi);
    }

    // Sahneye ge�i�i sa�layan fonksiyon
    void SahneyeGecis()
    {
        Application.Quit();
        Debug.Log("cikildi");
    }
}
