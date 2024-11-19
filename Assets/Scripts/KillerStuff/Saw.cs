using UnityEngine;

public class Saw : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player")
        {
            Destroy(collider2D.gameObject);
        }
    }
}
