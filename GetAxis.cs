using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_06 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Move()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMovement, 0, 0) * Time.deltaTime * _speed;

        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, verticalMovement, 0) * Time.deltaTime * _speed;

    }

    private void FixedUpdate()
    {
        Move();
    }
}
