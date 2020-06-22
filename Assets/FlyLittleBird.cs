using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets
{
    public class FlyLittleBird : MonoBehaviour
    {
        public float velocity = 1.4f;
        private Rigidbody2D _rb;

        // Start is called before the first frame update
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
            {
                _rb.velocity = Vector2.up * velocity;
            }
        }
    }
}