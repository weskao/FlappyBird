using UnityEngine;

namespace Assets
{
    public class Move : MonoBehaviour
    {
        private readonly float _speed = 1;

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
        }
    }
}