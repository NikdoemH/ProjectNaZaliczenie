using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float speed = 5f;
    public Vector2 Vel;


    // Start is called before the first frame update
    public void init()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        Vector2 newVelocity = new Vector2();
        newVelocity.x = Random.Range(-1f, 1f);
        newVelocity.y = Random.Range(-1f, 1f);
        rb2D.velocity = newVelocity.normalized * speed;
        Vel = rb2D.velocity;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        rb2D.velocity = Vector2.Reflect(Vel, collision.contacts[0].normal);
        Vel = rb2D.velocity;


        if (true)
        {

        }
    }

}
