using UnityEngine;
using System.Collections;

public class Lasers : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up * 10f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate()
	{
		
	}
}
