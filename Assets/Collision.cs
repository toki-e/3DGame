using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

  //  public GameObject cylinder;
   // public GameObject spherePrefab;
    Rigidbody rb;
    private float thrust = 20;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnCollisionEnter (UnityEngine.Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            rb.AddForce(0, 0, -thrust, ForceMode.Impulse);
            // rb.AddForce(transform.forward * thrust);
        }
    }

}
