using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1move : MonoBehaviour {

    public Transform player1;
    public float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 5, 0) * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
        }
    }
}
