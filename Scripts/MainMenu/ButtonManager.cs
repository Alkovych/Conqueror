using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.MainMenu
{
    class ButtonManager : MonoBehaviour
    {
        public void LoadLevel(int lvlNumber)
        {
            SceneManager.LoadScene(lvlNumber);
        }
    }
}
