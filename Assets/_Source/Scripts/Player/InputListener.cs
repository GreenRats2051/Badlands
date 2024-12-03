using UnityEngine;

namespace Player
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField]
        private PlayerShoot playerShoot;

        void Update()
        {
            if (playerShoot != null)
            {
                playerShoot.Rotate();
                if (Input.GetMouseButtonDown(0))
                {
                    playerShoot.Shoot();
                }
            }
        }
    }
}