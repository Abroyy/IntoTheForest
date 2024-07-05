using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Collections;
using TMPro;

public class SahneDuzenleme : MonoBehaviour
{
    
    void Start()
    {

    }

    public void LevelsMenu()
    {
        SceneManager.LoadScene("LevelsMenu");
        Time.timeScale = 1;
    }

    public void TekrarDene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Ileri()
    {
        // Bir sonraki sahneyi yükle (eðer varsa)
        int sonrakiSahneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (sonrakiSahneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sonrakiSahneIndex);
            Time.timeScale = 1;
        }
        else
        {
            Debug.LogWarning("Ýleri gidilecek baþka bir sahne bulunmuyor.");
        }
    }


    public void Game()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1;
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
        Time.timeScale = 1;
    }

    public void Level7()
    {
        SceneManager.LoadScene("Level7");
        Time.timeScale = 1;
    }

    public void Level8()
    {
        SceneManager.LoadScene("Level8");
        Time.timeScale = 1;
    }

    public void Level9()
    {
        SceneManager.LoadScene("Level9");
        Time.timeScale = 1;
    }
    public void Level10()
    {
        SceneManager.LoadScene("Level10");
        Time.timeScale = 1;
    }

    public void Level11()
    {
        SceneManager.LoadScene("Level11");
        Time.timeScale = 1;
    }

    public void Level12()
    {
        SceneManager.LoadScene("Level12");
        Time.timeScale = 1;
    }

    public void Level13()
    {
        SceneManager.LoadScene("Level13");
        Time.timeScale = 1;
    }

    public void Level14()
    {
        SceneManager.LoadScene("Level14");
        Time.timeScale = 1;
    }

    public void Level15()
    {
        SceneManager.LoadScene("Level15");
        Time.timeScale = 1;
    }

    public void Level16()
    {
        SceneManager.LoadScene("Level16");
        Time.timeScale = 1;
    }

    public void Level17()
    {
        SceneManager.LoadScene("Level17");
        Time.timeScale = 1;
    }

    public void Level18()
    {
        SceneManager.LoadScene("Level18");
        Time.timeScale = 1;
    }

    public void Level19()
    {
        SceneManager.LoadScene("Level19");
        Time.timeScale = 1;
    }

    public void Level20()
    {
        SceneManager.LoadScene("Level20");
        Time.timeScale = 1;
    }

    public void Level21()
    {
        SceneManager.LoadScene("Level21");
        Time.timeScale = 1;
    }
    public void Level22()
    {
        SceneManager.LoadScene("Level22");
        Time.timeScale = 1;
    }

    public void Level23()
    {
        SceneManager.LoadScene("Level23");
        Time.timeScale = 1;
    }

    public void Level24()
    {
        SceneManager.LoadScene("Level24");
        Time.timeScale = 1;
    }

    public void Level25()
    {
        SceneManager.LoadScene("Level25");
        Time.timeScale = 1;
    }
    public void Level26()
    {
        SceneManager.LoadScene("Level26");
        Time.timeScale = 1;
    }

    public void Level27()
    {
        SceneManager.LoadScene("Level27");
        Time.timeScale = 1;
    }

    public void Level28()
    {
        SceneManager.LoadScene("Level28");
        Time.timeScale = 1;
    }

    public void Level29()
    {
        SceneManager.LoadScene("Level29");
        Time.timeScale = 1;
    }

    public void Level30()
    {
        SceneManager.LoadScene("Level30");
        Time.timeScale = 1;
    }

    public void Level31()
    {
        SceneManager.LoadScene("Level31");
        Time.timeScale = 1;
    }

    public void Level32()
    {
        SceneManager.LoadScene("Level32");
        Time.timeScale = 1;
    }

    public void Level33()
    {
        SceneManager.LoadScene("Level33");
        Time.timeScale = 1;
    }



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
