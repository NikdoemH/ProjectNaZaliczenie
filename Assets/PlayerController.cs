using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 1f;
    public KeyCode UpKey = KeyCode.W ;
    public KeyCode DownKey = KeyCode.S ;
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y < 2.40)
        {
            transform.position += Vector3.up * Time.deltaTime * Speed;
        }

        if (Input.GetKey(DownKey) && transform.position.y > -2.35)
        {
            transform.position -= Vector3.up * Time.deltaTime * Speed ;
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb2 = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb2.velocity.magnitude > 25) return;
        Debug.Log(rb2.velocity.magnitude);

        rb2.velocity = new Vector2(rb2.velocity.x * 1.1f, rb2.velocity.y * 1.1f);
        BallController script = collision.gameObject.GetComponent<BallController>();
        script.Vel = rb2.velocity;
    }
}
