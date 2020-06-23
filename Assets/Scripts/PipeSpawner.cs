using UnityEngine;

namespace Assets.Scripts
{
    public class PipeSpawner : MonoBehaviour
    {
        public float MaxTime = 1;
        public GameObject pipe;
        public float Height;
        private float _timer = 0;

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            if (_timer > MaxTime)
            {
                GameObject newPipe = Instantiate(pipe);
                newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
                Destroy(newPipe, 7);
                _timer = 0;
            }

            _timer += Time.deltaTime;
        }
    }
}