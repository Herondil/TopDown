using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rgdbref;
    private Vector2 dir,
                    motion;

    public float speed;

    private void Awake()
    {
        rgdbref = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dir = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        //motion = dir * speed;
    }

    private void FixedUpdate()
    {
        motion = dir * speed;
        rgdbref.velocity = motion;
    }

}
