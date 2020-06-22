using UnityEngine;

namespace Assets
{
    public class PipeSpawner : MonoBehaviour
    {
        public float MaxTime = 1;
        public GameObject Pipe;
        public float Height;
        private float _timer = 0;

        // Start is called before the first frame update
        private void Start()
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
        }

        // Update is called once per frame
        private void Update()
        {
            if (_timer > MaxTime)
            {
                GameObject newPipe = Instantiate(Pipe);
                newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
                _timer = 0;
            }

            _timer += Time.deltaTime;
        }
    }
}