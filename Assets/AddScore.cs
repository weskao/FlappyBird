using System;
using UnityEngine;

namespace Assets
{
    public class AddScore : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Score.score ++;
        }
    }
}
