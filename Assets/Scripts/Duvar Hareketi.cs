using UnityEngine;

public class DuvarHareketi : MonoBehaviour
{
    public float hareketMesafesi = 2.0f; // Hareket edilecek mesafe
    public float hareketHizi = 1.0f; // Hareket hýzý
    private Vector2 baslangicPozisyonu;

    void Start()
    {
        baslangicPozisyonu = transform.position;
    }

    void Update()
    {
        float sinDegeri = Mathf.Sin(Time.time * hareketHizi); // Sine dalgasý kullanarak hareket
        Vector2 yeniPozisyon = baslangicPozisyonu + new Vector2(0, sinDegeri * hareketMesafesi);
        transform.position = yeniPozisyon;
    }
}

