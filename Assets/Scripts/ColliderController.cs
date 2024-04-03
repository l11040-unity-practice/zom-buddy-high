using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ColliderController : MonoBehaviour
{
    private TilemapRenderer _tilemapRenderer;
    public bool ShowCollider = false;
    void Start()
    {
        _tilemapRenderer = GetComponent<TilemapRenderer>();
        _tilemapRenderer.enabled = ShowCollider;
    }
}
