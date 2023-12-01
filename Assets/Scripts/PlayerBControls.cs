using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBControls : MonoBehaviour
{
    public float speed = 0.5f;
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }

}
