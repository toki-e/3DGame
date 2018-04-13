using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    public float moveSpeed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if (Input.GetKey(rightKey)) {
            transform.Translate(-moveSpeed, 0, 0);
        }

    }

}
