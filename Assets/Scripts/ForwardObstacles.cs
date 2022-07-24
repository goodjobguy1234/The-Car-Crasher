using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardObstacles : MonoBehaviour
{
    // private GameObject playerRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // playerRb = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!(GameObject.Find("Player").GetComponent<PlayerController>().isGameOver)) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
        // if (playerRb.GetComponent<PlayerController>().isRunning) {
        //     transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // }
    }
}
