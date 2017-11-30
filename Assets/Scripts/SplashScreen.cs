using UnityEngine;
using System.Collections;

namespace Dota2
{
    public class SplashScreen : MonoBehaviour
    {
        private const string nextScene = "CharacterChoice";
        LevelLoader levelLoader;

        void Start()
        {
            StartCoroutine(SkipSplash(1f));            
        }
        IEnumerator SkipSplash(float value)
        {
            yield return new WaitForSeconds(value);
            levelLoader = gameObject.AddComponent<LevelLoader>() as LevelLoader;
            levelLoader.LoadLevelAsync(nextScene);
        }       
    }
}

