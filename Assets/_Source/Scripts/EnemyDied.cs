using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Scripts
{
    public class EnemyDied : MonoBehaviour
    {
        public void Died()
        {
            SceneManager.LoadScene(0);
        }
    }
}
