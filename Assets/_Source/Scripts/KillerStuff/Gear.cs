using UnityEngine;

namespace KillerStuff
{
    public class Gear : MonoBehaviour
    {
        public Transform player;
        [SerializeField]
        private LayerMask layerMaskFloor;
        [SerializeField]
        private LayerMask layerMaskKillerStuff;

        void Update()
        {
            float radius = player.transform.localScale.x;
            Collider2D[] floor = Physics2D.OverlapCircleAll(transform.position, radius, layerMaskFloor);
            Collider2D[] deadItem = Physics2D.OverlapCircleAll(transform.position, radius, layerMaskKillerStuff);
            if (floor.Length != 0 && deadItem.Length != 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
