using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Rigidbody2D rigidbody2D;
    [SerializeField]
    private float pushForce;
    [SerializeField]
    private float rotationSpeedGun;

    public void Rotate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeedGun);
    }

    public void Shoot()
    {
        rigidbody2D.velocity = Vector2.zero;
        Vector3 shootDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        Vector3 pushDirection = -shootDirection;
        rigidbody2D.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);

        GameObject bulletInstantiate = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
