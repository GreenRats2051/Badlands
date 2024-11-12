using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D GameObjectRock;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObjectRock != null)
            {
                GameObjectRock.bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }
}
