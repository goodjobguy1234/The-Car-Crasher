using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float  forwardInput;
    private Vector3 startPos;
    private float repeatWidth;
    public bool isRunning;
    private float roadWidth;
    private Quaternion defaultRotation;
    public bool isGameOver;
    public ParticleSystem explosionParticle;
    // public GameObject projectilePrefab;
    // public GameObject roadObject;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GameObject.Find("Road").GetComponent<BoxCollider>().size.x;
        isRunning = false;
        defaultRotation = transform.rotation;
        roadWidth = 8.0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //back boundary
        if ((transform.position.z > startPos.z || transform.position.z < startPos.z + 10) && isGameOver == false){
            transform.position = SetZ(transform.position, startPos.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");

        // if (forwardInput > 0) {
           
        //     roadObject.transform.Translate(Vector3.left * Time.deltaTime * speed * forwardInput);
        //     // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //     isRunning = true;
        // } else {
        //     isRunning = false;
        // }

        if(horizontalInput != 0 && (transform.position.x > -roadWidth && transform.position.x < roadWidth) && isGameOver == false) {
            
            transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
            transform.Translate(Vector3.forward * Time.deltaTime * speed * 1);
        } else {
            transform.rotation = defaultRotation;
        }

        if (!(transform.position.x >= -roadWidth && transform.position.x <= roadWidth) && isGameOver == false) {
            if (transform.position.x <= -roadWidth) {
                transform.Rotate(Vector3.up, -1 * turnSpeed * Time.deltaTime);
                transform.Translate(Vector3.right * Time.deltaTime * speed * -1);
                transform.Translate(Vector3.forward * Time.deltaTime * speed * 1);
                // GetComponent<Rigidbody>().AddForce(Vector3.right * 0.2f, ForceMode.Impulse);
            } else {
                transform.Rotate(Vector3.up, 1 * turnSpeed * Time.deltaTime);
                transform.Translate(Vector3.right * Time.deltaTime * speed * 1);
                transform.Translate(Vector3.forward * Time.deltaTime * speed * 1);
                // GetComponent<Rigidbody>().AddForce(Vector3.left * 0.2f, ForceMode.Impulse);
            }
            
        }
   
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // if (Input.GetKeyDown(KeyCode.UpArrow)) {

        // }
       
    }

    // void LateUpdate() {
        //  if (transform.position.z < startPos.z - repeatWidth) {
        //     transform.position = SetZ(transform.position, startPos.z);
        // } 
    // }

    Vector3 SetZ(Vector3 vector, float z)
    {
        vector.z = z;
        return vector;
    } 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock" || other.tag == "Van") {
            isGameOver = true;
            explosionParticle.Play();
        }
    }
}
