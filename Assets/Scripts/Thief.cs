using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")>0)
        {
            rb.AddForce(Vector2.right* speed);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(Vector2.left* speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector2.up* speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(Vector2.down* speed);
        }
    }
}
