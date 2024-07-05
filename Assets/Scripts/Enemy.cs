using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f; // Düþmanýn hýzý
    public float patrolDistance = 5f; // Düþmanýn gidip gelme mesafesi
    public Transform player; // Rakip (örneðin, karakter) referansý
    public Animator animator; // Animasyon oynatýcý referansý
    public LayerMask playerLayer; // Rakipin layer'ý

    private bool movingRight = true; // Düþmanýn hareket yönü

    private void Update()
    {
        // Rakibi algýla ve saldýrý animasyonunu oynat
        DetectAndAttack();

        // Düþmanýn hareketini kontrol et
        Patrol();
    }

    void Patrol()
    {
        // Düþmanýn gidip gelmesi
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // Düþmanýn belirli bir mesafeden dönmesi
        if (Mathf.Abs(transform.position.x - player.position.x) < patrolDistance)
        {
            Flip();
        }
    }

    void Flip()
    {
        // Düþmanýn yönünü çevir
        movingRight = !movingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void DetectAndAttack()
    {
        // Rakibi algýla
        Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, 1f, playerLayer);

        if (playerCollider != null)
        {
            // Saldýrý animasyonunu oynat
            animator.SetTrigger("enemyattack");

            // Burada rakibe vurma veya baþka bir iþlemi gerçekleþtirebilirsiniz.
            // Örneðin: playerCollider.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }
}
