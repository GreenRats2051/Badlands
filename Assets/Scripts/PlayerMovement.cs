using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private float force;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float currentRotation;

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
            currentRotation = transform.rotation.eulerAngles.z;
            transform.rotation = Quaternion.Euler(0, 0, Mathf.LerpAngle(currentRotation, 0, Time.deltaTime * rotationSpeed));
        }
    }
}
