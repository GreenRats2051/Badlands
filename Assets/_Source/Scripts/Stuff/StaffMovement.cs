using UnityEngine;

namespace Stuff
{
    public class StaffMovement : MonoBehaviour
    {
        [SerializeField]
        private Transform[] pointPosition;
        [SerializeField]
        private int index;
        [SerializeField]
        private float speed;
        private float distance;

        void Update()
        {
            if (pointPosition.Length != 0)
            {
                distance = Vector2.Distance(transform.position, pointPosition[index].position);
                transform.position = Vector3.MoveTowards(transform.position, pointPosition[index].position, speed * Time.deltaTime);
                if (distance <= 0.1f)
                {
                    index++;
                }
                if (index >= pointPosition.Length && distance <= 0.1f)
                {
                    index = 0;
                }
            }
        }
    }
}