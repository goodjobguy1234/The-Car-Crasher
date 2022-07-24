using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandle : MonoBehaviour
{
    public GameObject explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) { 
        
        if(other.tag == "Rock" || other.tag == "Van") {
            explosionParticle = Instantiate(explosionParticle, transform.position,  Quaternion.identity) as GameObject;
            Destroy (explosionParticle, 3);
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        } else if (other.tag == "Crate") {
            Destroy(gameObject);
        }
        else {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 0.5f,  ForceMode.Impulse);
        }
        
    } 

    // void OnCollisionEnter(Collision collision) {
    //     if (collision.gameObject.CompareTag("Van")) {
    //         explosionParticle = collision.gameObject.GetComponent<ParticleSystem>();
    //         explosionParticle.Play();
    //     }

    //     if (collision.gameObject.CompareTag("Rock")) {
    //         explosionParticle = collision.gameObject.GetComponent<ParticleSystem>();
    //         explosionParticle.Play(); 
    //     }
    // }
}
