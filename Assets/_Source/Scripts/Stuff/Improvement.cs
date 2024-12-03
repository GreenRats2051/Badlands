using UnityEngine;

namespace Stuff
{
    public class Improvement : MonoBehaviour
    {
        [SerializeField]
        private float playerSize;

        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.tag == "Player")
            {
                collider2D.transform.localScale = new Vector2(playerSize, playerSize);
                Destroy(gameObject);
            }
        }
    }
}