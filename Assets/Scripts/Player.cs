using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator _anime;
    Rigidbody2D _rb;
    Vector2 _movement;
    public float Speed = 4f;

    void Start()
    {
        _anime = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 newPos = _rb.position + _movement.normalized * Speed * Time.fixedDeltaTime;
        _rb.MovePosition(newPos);
        SetMoveAnimation();
    }

    void SetMoveAnimation()
    {
        bool isDiagonalMovement = Mathf.Abs(_movement.x) > 0.01f && Mathf.Abs(_movement.y) > 0.01f;

        _anime.SetFloat("MoveX", _movement.x);
        _anime.SetFloat("MoveY", _movement.y);

        if (isDiagonalMovement)
        {
            _anime.SetFloat("MoveY", 0);
        }
    }
}
