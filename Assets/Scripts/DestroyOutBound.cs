using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{ 
    public float outBound = 200f;
    public float yBound = 30f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.z > outBound) { 
            Destroy(gameObject); 
        }

        if (gameObject.tag =="bullet" && transform.position.y < -yBound) {
            Destroy(gameObject);
        }
    }
}
