using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonKontrol5 : MonoBehaviour
{
    // Animator bile�eni
    private Animator animator;

    void Start()
    {

        animator = GetComponent<Animator>();
    }


    public void OnButonClick()
    {

        animator.SetTrigger("settingsanim");


        float animasyonSuresi = 0.3f;


        Invoke("SahneyeGecis", animasyonSuresi);
    }


    void SahneyeGecis()
    {

        string yeniSahneAdi = "Settings";

        SceneManager.LoadScene(yeniSahneAdi);
    }
}
