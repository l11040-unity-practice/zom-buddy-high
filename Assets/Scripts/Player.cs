using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator _anime;

    public float Speed = 5f;

    void Start()
    {
        _anime = GetComponent<Animator>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector2(hInput, vInput);

        transform.position += movement * Speed * Time.deltaTime;

        _anime.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        _anime.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
