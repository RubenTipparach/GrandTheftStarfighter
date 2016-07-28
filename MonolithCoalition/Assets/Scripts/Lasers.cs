using UnityEngine;
using System.Collections;

public class Lasers : MonoBehaviour {

	[SerializeField]
	GameObject explosion;

	[SerializeField]
	float lifeDuration = 5f;

	float lifeTime = 0;

	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up * 10f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		lifeTime += Time.deltaTime;

		if(lifeTime >= lifeDuration)
		{
			Destroy(gameObject);
		}
    }

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("dfsdfE");

		GameObject.Instantiate(explosion, transform.position, transform.rotation);

		Destroy(gameObject);
	}

	void FixedUpdate()
	{
		
	}
}
