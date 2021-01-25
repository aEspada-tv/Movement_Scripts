using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_07 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * -_speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.up * -_speed * Time.deltaTime);
        }
    }

    void Update()
    {
        Move();
    }

}
