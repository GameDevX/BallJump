using UnityEngine;
using System.Collections;

public class ball_move : MonoBehaviour {
    public float speed;
	private Vector3 vec;
	private bool degdimi = false;



    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
		vec = new Vector3 (0, 600, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
        float moveHorizontal = Input.GetAxis("Horizontal");
        

        Vector3 movement = new Vector3(moveHorizontal,0, 0.0f);

        rb.AddForce(movement * speed);

		if(Input.GetKey(KeyCode.Space) && degdimi == false){
			
			rb.AddForce (vec);
			degdimi = true;
		}
    }

	void OnCollisionEnter(Collision degennesne){
		if (degennesne.gameObject.tag == "zemin") {
			degdimi = false;

		}
	}


     
}

