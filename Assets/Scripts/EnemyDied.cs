using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyDied : MonoBehaviour
{
    public void Died()
    {
        SceneManager.LoadScene(0);
    }
}
