using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    [SerializeField]
    private Transform pointSpawnRoom;
    [SerializeField]
    private GameObject[] rooms;
    private int index;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player")
        {
            index = Random.Range(0, rooms.Length);
            Instantiate(rooms[index], pointSpawnRoom.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
