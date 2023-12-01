using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAControls : MonoBehaviour
{
    public float speed = 12;
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
 Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Space.World);
    }    public class PlayerAControlVelocity : MonoBehaviour
    {
        Rigidbody2D rb;
        public float acc = 8;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        void FixedUpdate()
        {
            rb.velocity += new Vector2(
            Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime,
            Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime);
        }
    }
}
    
