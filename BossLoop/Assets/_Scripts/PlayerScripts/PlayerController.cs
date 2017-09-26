using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    public Rigidbody2D rigidbody;
    private Animator animator;
    Vector2 AxisInput;

    // Use this for initialization
    void Start () {
        rigidbody.freezeRotation = true;
        animator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.W))
        {
            //transform.position += Vector3.up * speed * Time.deltaTime;
            animator.SetInteger("Direction", 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            //transform.position += Vector3.down * speed * Time.deltaTime;
            animator.SetInteger("Direction", 2);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            animator.SetInteger("Direction", 3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;
            animator.SetInteger("Direction", 1);
        }
        

        Vector2 AxisInput = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
        rigidbody.velocity = AxisInput * speed;

    }

    
}
