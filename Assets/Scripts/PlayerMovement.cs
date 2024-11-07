using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private float force;
    [SerializeField]
    private float rotationSpeed;

    public void Walk(bool moveLeft, bool moveRight, bool moveUp)
    {
        if (moveUp)
        {
            rigidbody.velocity = Vector2.zero;
            Debug.Log("You fly.");
            if (moveLeft)
            {
                Debug.Log("You move left");
                rigidbody.AddForce(Vector2.left * 2, ForceMode2D.Impulse);
            }
            if (moveRight)
            {
                Debug.Log("You move right");
                rigidbody.AddForce(Vector2.right * 2, ForceMode2D.Impulse);
            }
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            Quaternion currentRotation = transform.rotation;
            Quaternion targetRotation = Quaternion.Euler(Vector3.zero);
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
