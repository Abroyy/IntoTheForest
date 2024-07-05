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

    // Belirli bir süre boyunca metni ekranda göster
    public void TextGoster()
    {
        // Level adýný al ve metni oluþtur
        string levelAdi = SceneManager.GetActiveScene().name;
        levelText.text = levelAdi;

        // Texti aktif hale getir
        levelText.gameObject.SetActive(true);
    }
}
