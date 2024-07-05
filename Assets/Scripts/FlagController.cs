using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour
{
    public int nextLevelIndex;  // Bir sonraki seviyenin indeksi

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            // Bayra�a dokunuldu�unda bir sonraki seviyenin kilidini a�
            UnlockNextLevel();
        }
    }

    void UnlockNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        // PlayerPrefs'ten bir sonraki seviyenin kilidini a�
        int nextLevel = currentLevelIndex + 1;

        // E�er nextLevelIndex belirlenmi�se, onu kullan
        if (nextLevelIndex > 0)
        {
            nextLevel = nextLevelIndex;
        }

        PlayerPrefs.SetInt("Level" + nextLevel.ToString(), 1);

        // Burada bir sonraki seviyeye ge�i� yapabilirsiniz, iste�e ba�l�
        // SceneManager.LoadScene("Level" + nextLevel.ToString());
    }
}
