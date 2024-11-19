using UnityEngine;

public class StaffRotate : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }
}
