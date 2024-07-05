using UnityEngine;

public class DamlaKontrol : MonoBehaviour
{
    private Vector3 baslangicKonumu;
    public float geriDonmeSuresi = 3f;
    private float gecenSure = 0f;

    void Start()
    {
        // Damla'nýn baþlangýç konumunu kaydet
        baslangicKonumu = transform.position;
    }

    void Update()
    {
        

        // Zamaný takip et
        gecenSure += Time.deltaTime;

        // Belirli bir süre sonra baþlangýç konumuna geri dön
        if (gecenSure >= geriDonmeSuresi)
        {
            
            transform.position = baslangicKonumu;

            
            gecenSure = 0f;
        }
    }
}
