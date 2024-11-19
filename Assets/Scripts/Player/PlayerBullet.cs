using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Enemy")
        {
            Debug.Log("Enemy Died!");
            Time.timeScale = 0.4f;
        }
    }
}
