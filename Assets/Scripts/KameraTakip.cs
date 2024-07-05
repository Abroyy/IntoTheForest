using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform hedef;
    public float yumuþaklýk = 5f;

    private void FixedUpdate()
    {
        if (hedef != null)
        {
            Vector3 yeniPozisyon = new Vector3(hedef.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, yeniPozisyon, yumuþaklýk * Time.fixedDeltaTime);
        }
    }
}

