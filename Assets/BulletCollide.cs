using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollide : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) { 

    // if(other.tag == "bullet") {
    //     explosionParticle.transform.position = other.gameObject.transform.position;
    //     explosionParticle.Play();
        
    // } 
    } 

    
}
