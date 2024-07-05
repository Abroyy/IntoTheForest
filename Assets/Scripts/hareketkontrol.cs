using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class KarakterKontrol : MonoBehaviour
{
    public float hiz = 5f;
    public float ziplamaGucu = 25f;
    private bool ziplamaKontrol = false;
    private Rigidbody2D rb;
    private bool ileri = false;
    private bool geri = false;
    private float horizontal = 0f;
    private Animator anim;
    public GameObject gameoverpanel;
    public GameObject nextlevelpanel;
    public GameObject durdurpanel;
    public GameObject durdurbutton;
    public ParticleSystem explosionEffect; 
    public float explosionDuration = 0.8f;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;


   
    private bool isGameOver = false;

    void Start()
    {
        explosionEffect.Stop();
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
        durdurbutton.SetActive(true);

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gameoverpanel.SetActive(false);
        nextlevelpanel.SetActive(false);
        durdurpanel.SetActive(false);
        


    }

    void Update()
    {
        horizontal = 0f;
        hareket();
    }

    void hareket()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);

        if (hit.collider != null)
        {
            if (ileri)
            {
                horizontal = 1f;
               
            }
            else if (geri)
            {
                horizontal = -1f;
                
            }
        }

        Vector2 hareket = new Vector2(horizontal * hiz, rb.velocity.y);
        rb.velocity = hareket;
    }




    public void OnPressIleri()
    {
        ileri = true;
      
        anim.SetBool("walkanim1", true);
        
        
    }

    public void OnReleaseIleri()
    {
        ileri = false;
        anim.SetBool("walkanim1", false);

    }

    public void OnPressGeri()
    {
        geri = true;
        
        anim.SetBool("walkanim1ters", true);
        
    }

    public void OnReleaseGeri()
    {
        geri= false;
        anim.SetBool("walkanim1ters", false);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Yere Ýnince Zýplama Kontrolünü Sýfýrla
        if (collision.gameObject.CompareTag("Zemin") || collision.gameObject.CompareTag("destek"))
        {
            anim.SetBool("zýpla anim", false);
            ziplamaKontrol = false;
        }

        if (collision.gameObject.CompareTag("fire") && !isGameOver)
        {

            GetComponent<SpriteRenderer>().enabled = false;
            PlayExplosionEffect();

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            // Belirli bir süre sonra Game Over panelini göster
            Invoke("ShowGameOverPanel", explosionDuration);

            isGameOver = true;

        }

        if (collision.gameObject.CompareTag("kaktüs") && !isGameOver)
        {
            

            GetComponent<SpriteRenderer>().enabled = false;
            PlayExplosionEffect();

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            // Belirli bir süre sonra Game Over panelini göster
            Invoke("ShowGameOverPanel", explosionDuration);

            isGameOver = true;

        }

        if (collision.gameObject.CompareTag("bayrak"))
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            nextlevelpanel.SetActive(true);
            durdurbutton.SetActive(false);
            Time.timeScale = 0;
        }

        if (collision.gameObject.CompareTag("eventsystem") && !isGameOver)
        {
           

            GetComponent<SpriteRenderer>().enabled = false;

            PlayExplosionEffect();

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            // Belirli bir süre sonra Game Over panelini göster
            Invoke("ShowGameOverPanel", explosionDuration);

            isGameOver = true;

            

        }

        if (collision.gameObject.CompareTag("enemy") && !isGameOver)
        {

            GetComponent<SpriteRenderer>().enabled = false;
            PlayExplosionEffect();

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            // Belirli bir süre sonra Game Over panelini göster
            Invoke("ShowGameOverPanel", explosionDuration);

            isGameOver = true;
        }


        if (collision.gameObject.CompareTag("trap") && !isGameOver)
        {

            GetComponent<SpriteRenderer>().enabled = false;
            PlayExplosionEffect();

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            durdurbutton.SetActive(false);

            // Belirli bir süre sonra Game Over panelini göster
            Invoke("ShowGameOverPanel", explosionDuration);

            isGameOver = true;
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

    private void ShowGameOverPanel()
    {
        // Game Over panelini aktif hale getir
        if (gameoverpanel != null)
        {
            gameoverpanel.SetActive(true);
        }

        // Oyunu duraklat (isteðe baðlý)
        Time.timeScale = 0f;
    }


    public void OnJumpButtonPressed()
    {
        if (!ziplamaKontrol)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);

            if (hit.collider != null)
            {
                Jump();
            }
        }
    }


    private void Jump()
    {

        anim.SetBool("zýpla anim", true);
        rb.velocity = new Vector2(rb.velocity.x, ziplamaGucu);
        ziplamaKontrol = true;
    }


    public void DurdurPanel()
    {
        Time.timeScale = 0;
        durdurpanel.SetActive(true);
        durdurbutton.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
    }

    public void DevamEttir()
    {
        Time.timeScale = 1;
        durdurpanel.SetActive(false);
        durdurbutton.SetActive(true);
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
    }
}

