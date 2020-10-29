using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            _rigidbody2D.AddForce(Vector2.right * _speed);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            _rigidbody2D.AddForce(Vector2.left * _speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            _rigidbody2D.AddForce(Vector2.up * _speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            _rigidbody2D.AddForce(Vector2.down * _speed);
        }
    }
}
