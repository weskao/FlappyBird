﻿using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public class FlyLittleBird : MonoBehaviour
    {
        public GameManager GameManager;
        public float Velocity = 1;
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
                _rb.velocity = Vector2.up * Velocity;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.GameOver();
        }
    }
}