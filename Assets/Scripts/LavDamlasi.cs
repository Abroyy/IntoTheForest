using UnityEngine;

public class DamlaKontrol : MonoBehaviour
{
    private Vector3 baslangicKonumu;
    public float geriDonmeSuresi = 3f;
    private float gecenSure = 0f;

    void Start()
    {
        // Damla'n�n ba�lang�� konumunu kaydet
        baslangicKonumu = transform.position;
    }

    void Update()
    {
        

        // Zaman� takip et
        gecenSure += Time.deltaTime;

        // Belirli bir s�re sonra ba�lang�� konumuna geri d�n
        if (gecenSure >= geriDonmeSuresi)
        {
            
            transform.position = baslangicKonumu;

            
            gecenSure = 0f;
        }
    }
}
