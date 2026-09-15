using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections.Concurrent;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    public float speed = 5;
    public Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }

    void OnMousePos(InputValue value)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
        transform.position = new Vector2(mousePos.x, transform.position.y);
    }

    void Gravity()
    {
        rb.gravityScale = 0;
        rb.linearVelocity = new Vector2 (rb.linearVelocityX, 0);
    }
}
