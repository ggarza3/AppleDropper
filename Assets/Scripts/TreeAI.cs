using UnityEngine;

public class TreeAI : MonoBehaviour
{
    public float speed = 16f;
    public float maxSpeed = 60f;
    public GameObject leftBound;
     public GameObject rightBound;
     public bool isFacingRight = true;
     public GameObject apple;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("MakeApple", 1.5f, 1.5f);
        InvokeRepeating("MakeApple", 4f, 2);
        InvokeRepeating("MakeApple", 7.2f, 1.6f);
        InvokeRepeating("MakeApple", 13.7f, 2.9f);

        InvokeRepeating("speedUp", 8, 6);
    }

    // Update is called once per frame
    void Update()
    {


        if (isFacingRight)
        {
            transform.position = new Vector2(transform.position.x + Mathf.Min(speed, maxSpeed) * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Mathf.Min(speed, maxSpeed) * Time.deltaTime, transform.position.y);
        }
        if (transform.position.x > rightBound.transform.position.x)
        {
            isFacingRight = false;
        }
        if(transform.position.x < leftBound.transform.position.x)
        {
            isFacingRight = true;
        }
    }

    void MakeApple()
    {
        Instantiate(apple, transform.position, Quaternion.identity);
    }

    void speedUp()
    {
        speed = speed + 2;
    }
}
