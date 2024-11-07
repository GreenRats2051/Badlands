using UnityEngine;

public class PlayerInputListner : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;
    [SerializeField]
    private KeyCode moveLeft;
    [SerializeField]
    private KeyCode moveRight;
    [SerializeField]
    private KeyCode moveUp;

    void Start()
    {

    }
    void Update()
    {
        if (playerMovement != null)
        {
            playerMovement.Walk(Input.GetKey(moveLeft), Input.GetKey(moveRight), Input.GetKey(moveUp));
        }
    }
}
