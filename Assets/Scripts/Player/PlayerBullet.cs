using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Enemy")
        {
            Debug.Log("Enemy Died!");
<<<<<<< HEAD
            collider2D.GetComponent<EnemyDied>().Died();
            Time.timeScale = 0.4f;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
=======
            Time.timeScale = 0.4f;
>>>>>>> e8aee989437b84d97b56c75750cf0eecb16ce432
        }
    }
}
