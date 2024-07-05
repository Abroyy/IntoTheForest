using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonKontrol4 : MonoBehaviour
{
    // Animator bileþeni
    private Animator animator;

    void Start()
    {
       
        animator = GetComponent<Animator>();
    }

   
    public void OnButonClick()
    {
       
        animator.SetTrigger("backanim");

       
        float animasyonSuresi = 0.3f;

       
        Invoke("SahneyeGecis", animasyonSuresi);
    }

    
    void SahneyeGecis()
    {
       
        string yeniSahneAdi = "MainMenu"; 

        SceneManager.LoadScene(yeniSahneAdi);
        Time.timeScale = 1f;
    }
}
