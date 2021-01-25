using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_02 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    void Move()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * (Time.deltaTime * _speed));
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * (Time.deltaTime * _speed));
        }

    }
    

    void Update()
    {
        
        Move();
    }
}
