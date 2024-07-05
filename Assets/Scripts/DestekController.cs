using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DestekController : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("eventsystem"))
        {
            
            Destroy(gameObject);
        }
    }

}
