using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardRoad : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(GameObject.Find("Player").GetComponent<PlayerController>().isGameOver)) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
    }
}
