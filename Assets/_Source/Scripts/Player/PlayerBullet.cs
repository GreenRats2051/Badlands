using UnityEngine;

namespace Player
{
    public class PlayerBullet : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.tag == "Enemy")
            {
                Debug.Log("Enemy Died!");
                collider2D.GetComponent<EnemyDied>().Died();
                Time.timeScale = 0.4f;
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
                Time.timeScale = 0.4f;
            }
        }
    }
}
