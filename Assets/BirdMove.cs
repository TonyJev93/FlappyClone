using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Bird Jump");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = Vector2.left * speed * 2;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = Vector2.right * speed;
        }

    }
}
