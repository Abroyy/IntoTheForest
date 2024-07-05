using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public GameObject hareketEttirilecekNesne;
    private Animator anim;
    private bool isButtonPressed = false;
    private Vector3 initialPosition;

    void Start()
    {
        anim = GetComponent<Animator>();
        initialPosition = hareketEttirilecekNesne.transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character") && !isButtonPressed)
        {
            isButtonPressed = true;
            anim.SetBool("buttonpressed", true);
            StartCoroutine(NesneyiHareketEttirVeSifirla());
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            anim.SetBool("buttonpressed", false);
        }
    }

    IEnumerator NesneyiHareketEttirVeSifirla()
    {
        Vector3 baslangicPozisyonu = hareketEttirilecekNesne.transform.position;

        hareketEttirilecekNesne.transform.Translate(Vector3.down * 200f * Time.deltaTime);

        yield return new WaitForSeconds(3.5f);

        StartCoroutine(MoveBackToInitialPosition(baslangicPozisyonu));
        isButtonPressed = false;
    }

    IEnumerator MoveBackToInitialPosition(Vector3 initialPos)
    {
        float elapsedTime = 0f;
        float duration = 2f; // Adjust this value for the desired duration of the movement

        while (elapsedTime < duration)
        {
            hareketEttirilecekNesne.transform.position = Vector3.Lerp(hareketEttirilecekNesne.transform.position, initialPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        hareketEttirilecekNesne.transform.position = initialPos;
    }
}
