using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonKontrol : MonoBehaviour
{
    // Animator bileþeni
    private Animator animator;

    void Start()
    {
        // Animator bileþenini al
        animator = GetComponent<Animator>();
    }

    // Buton týklandýðýnda çaðrýlan fonksiyon
    public void OnButonClick()
    {
        // Animasyonu baþlat
        animator.SetTrigger("playanim");

        // Animasyonun uzunluðunu al
        float animasyonSuresi = 0.3f;

        // Belirtilen süre boyunca bekleyerek sahneye geçiþi gerçekleþtir
        Invoke("SahneyeGecis", animasyonSuresi);
    }

    // Sahneye geçiþi saðlayan fonksiyon
    void SahneyeGecis()
    {
        // Yeni sahnenin adýný belirt
        string yeniSahneAdi = "LevelsMenu"; // Deðiþtirmeniz gereken kýsým

        // Belirtilen sahneye geçiþ yap
        SceneManager.LoadScene(yeniSahneAdi);
    }
}
