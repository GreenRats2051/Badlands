using UnityEngine;

public class ReSize : MonoBehaviour
{
    [SerializeField]
    private float newSize;

    void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "Player")
        {
            Collider2D.transform.localScale = new Vector2 (newSize, newSize);
            Destroy(gameObject);
        }
    }
}
