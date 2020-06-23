using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class GameManager : MonoBehaviour
    {
        public GameObject GameOverCanvas;

        // Start is called before the first frame update
        private void Start()
        {
            GameOverCanvas.SetActive(false);
            Time.timeScale = 1;
        }

        public void GameOver()
        {
            GameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void Replay()
        {
            SceneManager.LoadScene(0);
        }
    }
}