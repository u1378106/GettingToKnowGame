using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D player;

    float horizontal;

    public float moveSpeed = 10.0f;

    private bool boundReached;

    public int redColorCounter, greenColorCounter, blueColorCounter;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Image>().color == Color.red)
        {
            redColorCounter++;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.GetComponent<Image>().color == Color.green)
        {
            greenColorCounter++;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.GetComponent<Image>().color == Color.blue)
        {
            blueColorCounter++;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {      
        //if(redColorCounter == 3 || greenColorCounter == 3 || blueColorCounter == 3)
            horizontal = Input.GetAxisRaw("Horizontal");
            //Debug.Log("player pos: " + transform.position);
    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontal * moveSpeed, 0f);
    }
}