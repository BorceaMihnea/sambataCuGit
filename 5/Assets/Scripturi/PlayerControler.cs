using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float jumpForce;
    public float moveForce;
    private bool canJump = false;
    private bool hasSwichedLayers = false;
    private Vector3 startPos;
    
    void Start()
    {
        startPos = new Vector3(-10, 1.5f, 0);
    }

    
    void Update()
    {
        if(Input.GetKey("a")){
            this.GetComponent<Rigidbody>().velocity = new Vector3(-moveForce*Time.deltaTime, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z );
        }
        if(Input.GetKey("d")){
            this.GetComponent<Rigidbody>().velocity = new Vector3(moveForce*Time.deltaTime, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z );
    }
    if(Input.GetKeyDown("w") && canJump){
        canJump=false;
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
    }
    if(Input.GetKeyDown("space")){
        if(hasSwichedLayers){
            this.transform.position= new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                0
            );
        } else {this.transform.position= new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                10
        );

        }
        
        hasSwichedLayers=!hasSwichedLayers;
    }
    if(transform.position.y <-10){
        this.transform.position = startPos;
        hasSwichedLayers=false;
    }

}
void OnCollisionEnter(Collision collision) {
    canJump=true;
    if(collision.gameObject.tag == "Finish"){
        this.transform.position =new Vector3(50, 1.5f, 0);
        hasSwichedLayers=false;
    }
    if(collision.gameObject.tag == "Obstacol"){
      this.transform.position = startPos;
      hasSwichedLayers=false;  
    }
    if(collision.gameObject.tag == "trambulina"){
        GetComponent<Rigidbody>().AddForce(0,700,0);

    }
    
}
 void OnTriggerEnter(Collider moneduta) {
    Destroy(moneduta.gameObject);
}
}
