using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneExplorer
{
    
    public class Spinner : MonoBehaviour
    {
        public float speed; // rotation speed
        public Vector3 localAxis;   // local axis
                                    // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(localAxis * speed * Time.deltaTime);
        }
    }
}