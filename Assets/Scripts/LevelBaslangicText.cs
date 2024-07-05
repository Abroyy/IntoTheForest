using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelBaslangicText : MonoBehaviour
{
    public TextMeshProUGUI levelText;

    void Start()
    {
        TextGoster();
    }

    // Belirli bir s�re boyunca metni ekranda g�ster
    public void TextGoster()
    {
        // Level ad�n� al ve metni olu�tur
        string levelAdi = SceneManager.GetActiveScene().name;
        levelText.text = levelAdi;

        // Texti aktif hale getir
        levelText.gameObject.SetActive(true);
    }
}
