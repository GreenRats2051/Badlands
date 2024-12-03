using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts
{
    public class Buttons : MonoBehaviour
    {
        public void Selectlevel(int index)
        {
            SceneManager.LoadScene(index);
        }
    }
}
