using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stuff
{
    public class Saw : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.tag == "Player")
            {
                Destroy(collider2D.gameObject);
                SceneManager.LoadScene(0);
            }
        }
    }
}