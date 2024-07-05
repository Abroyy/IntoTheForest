using UnityEngine;

public class DuvarHareketi3 : MonoBehaviour
{
    public float hareketMesafesi = 2.0f; // Hareket edilecek mesafe
    public float hareketHizi = 1.0f; // Hareket hýzý
    private Vector2 baslangicPozisyonu;
    private bool sagaDon = true; // Saða doðru dönme kontrolü

    void Start()
    {
        baslangicPozisyonu = transform.position;
        
    }

    void Update()
    {
        float sinDegeri = Mathf.Sin(Time.time * hareketHizi); // Sine dalgasý kullanarak hareket
        Vector2 hareketMiktari = new Vector2(sinDegeri * hareketMesafesi, 0);
        Vector2 yeniPozisyon = baslangicPozisyonu + hareketMiktari;
        transform.position = yeniPozisyon;

        
        // En sola ulaþtýðýnda scale'i tersine çevir
        if (sagaDon && sinDegeri <= -0.99f)
        {
            transform.localScale = new Vector3(-0.135f, 0.135f, 1);
            sagaDon = false;
        }
        // En saða ulaþtýðýnda scale'i geri çevir
        else if (!sagaDon && sinDegeri >= 0.99f)
        {
            transform.localScale = new Vector3(0.135f, 0.135f, 1);
            sagaDon = true;
        }


        if (sagaDon && sinDegeri == 0f)
        {
            transform.localScale = new Vector3(-0.135f, 0.135f, 1);
            sagaDon = false;
        }


    }
}
