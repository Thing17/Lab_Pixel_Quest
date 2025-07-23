using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk_temp : MonoBehaviour
{
    private Rigidbody2D rb;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }
}
