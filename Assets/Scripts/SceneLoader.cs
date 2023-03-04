using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace EnterKratos
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField]
        private SceneAsset scene;

        [SerializeField]
        private bool loadOnStart;

        [SerializeField]
        private bool loadAsync;

        [SerializeField] private UnityEvent onSceneLoaded;

        public void LoadSceneAdditive()
        {
            if (loadAsync)
            {
                SceneManager.LoadSceneAsync(scene.name, LoadSceneMode.Additive);
            }
            else
            {
                SceneManager.LoadScene(scene.name, LoadSceneMode.Additive);
            }

            onSceneLoaded.Invoke();
        }

        private void Start()
        {
            if (loadOnStart)
            {
                LoadSceneAdditive();
            }
        }
    }
}
