using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject SpawnActor;
    public bool isWork = false;

    void Update()
    {
        if (!isWork)
        {
            GameObject x = Instantiate(SpawnActor, transform.position, Quaternion.identity);
            BallController script = x.GetComponent<BallController>();
            script.speed = 5f;
            script.init();
            x.SetActive(true);
            isWork = true;
        }
    }
    public void setIsWork(bool value) => isWork = value;
}
