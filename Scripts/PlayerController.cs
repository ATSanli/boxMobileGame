using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;
    bool canJump;
    
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canJump)
        {
            //jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            canJump= true;
        }  
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag =="Ground")
        {
            canJump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("Level01");
        }
        if (other.gameObject.tag == "Sphere/Obstacle")
        {
            SceneManager.LoadScene("Level01");
        }
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.tag == "puan")
        {
            Destroy(other.gameObject);
        }
        


    }
   

}