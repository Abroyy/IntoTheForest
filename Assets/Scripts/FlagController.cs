using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour
{
    public int nextLevelIndex;  // Bir sonraki seviyenin indeksi

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            // Bayraða dokunulduðunda bir sonraki seviyenin kilidini aç
            UnlockNextLevel();
        }
    }

    void UnlockNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        // PlayerPrefs'ten bir sonraki seviyenin kilidini aç
        int nextLevel = currentLevelIndex + 1;

        // Eðer nextLevelIndex belirlenmiþse, onu kullan
        if (nextLevelIndex > 0)
        {
            nextLevel = nextLevelIndex;
        }

        PlayerPrefs.SetInt("Level" + nextLevel.ToString(), 1);

        // Burada bir sonraki seviyeye geçiþ yapabilirsiniz, isteðe baðlý
        // SceneManager.LoadScene("Level" + nextLevel.ToString());
    }
}
