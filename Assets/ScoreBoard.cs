using UnityEngine;

namespace Assets
{
    public class ScoreBoard : MonoBehaviour
    {
        public static int score = 0;

        // Start is called before the first frame update
        private void Start()
        {
            score = 0;
        }

        // Update is called once per frame
        private void Update()
        {
            GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        }
    }
}