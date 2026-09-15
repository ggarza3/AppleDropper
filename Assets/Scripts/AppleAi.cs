
using UnityEngine;
using UnityEngine.Rendering;

public class AppleAi : MonoBehaviour
{
    public Rigidbody2D rb;
    public float fallSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }

    void Gravity()
    {
        if (rb.linearVelocityY < 0)
        {
            rb.gravityScale = 0;
            rb.linearVelocity = new Vector2(rb.linearVelocityX, -fallSpeed);
        }
        //transform.position = new Vector2(transform.position.x, transform.position.y - 1 * Time.deltaTime * fallSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Death")){
            Destroy(gameObject);
        }

        if(other.gameObject.tag.Equals("Player")){
            Destroy(gameObject);
        }
    }
}
