using UnityEngine;
using UnityEngine.SceneManagement;

namespace Dota2
{
    public class LevelLoader : MonoBehaviour
    {
        public void LoadLevelAsync(string scene)
        {
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
