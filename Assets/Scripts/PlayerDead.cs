using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMaskFloor;
    [SerializeField]
    private LayerMask layerMaskDeadItem;

    void Update()
    {
        Collider2D[] floor = Physics2D.OverlapCircleAll(transform.position, radius, layerMaskFloor);
        Collider2D[] deadItem = Physics2D.OverlapCircleAll(transform.position, radius, layerMaskDeadItem);
        if (floor.Length != 0 && deadItem.Length != 0)
        {
            Destroy(gameObject);
        }
    }
}
