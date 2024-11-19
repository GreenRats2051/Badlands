using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    private Vector2 position;
    [SerializeField]
    private GameObject[] chunks;
    [SerializeField]
    private GameObject end;
    [SerializeField]
    private int maxChunks;

    void Start()
    {
        position = new Vector2(transform.position.x + 17, transform.position.y);
        for (int i = 0; i < maxChunks; i++)
        {
            int index = Random.Range(0, chunks.Length);
            GameObject newChunks = Instantiate(chunks[index], position, Quaternion.identity);
            position = new Vector2(newChunks.transform.position.x + 17, transform.position.y);
        }
        Instantiate(end, position, Quaternion.identity);
    }
}
