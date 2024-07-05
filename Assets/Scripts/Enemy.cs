using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f; // D��man�n h�z�
    public float patrolDistance = 5f; // D��man�n gidip gelme mesafesi
    public Transform player; // Rakip (�rne�in, karakter) referans�
    public Animator animator; // Animasyon oynat�c� referans�
    public LayerMask playerLayer; // Rakipin layer'�

    private bool movingRight = true; // D��man�n hareket y�n�

    private void Update()
    {
        // Rakibi alg�la ve sald�r� animasyonunu oynat
        DetectAndAttack();

        // D��man�n hareketini kontrol et
        Patrol();
    }

    void Patrol()
    {
        // D��man�n gidip gelmesi
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // D��man�n belirli bir mesafeden d�nmesi
        if (Mathf.Abs(transform.position.x - player.position.x) < patrolDistance)
        {
            Flip();
        }
    }

    void Flip()
    {
        // D��man�n y�n�n� �evir
        movingRight = !movingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void DetectAndAttack()
    {
        // Rakibi alg�la
        Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, 1f, playerLayer);

        if (playerCollider != null)
        {
            // Sald�r� animasyonunu oynat
            animator.SetTrigger("enemyattack");

            // Burada rakibe vurma veya ba�ka bir i�lemi ger�ekle�tirebilirsiniz.
            // �rne�in: playerCollider.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }
}
