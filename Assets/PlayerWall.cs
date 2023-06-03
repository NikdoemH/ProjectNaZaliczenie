using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : MonoBehaviour
{

    public GameObject obj;
    private SpawnBall script;

    // Start is called before the first frame update
    void Start()
    {
        script = obj.gameObject.GetComponent<SpawnBall>();    
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        script.setIsWork(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
