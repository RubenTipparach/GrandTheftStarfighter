using UnityEngine;
using System.Collections;

public class Ship_Controller : MonoBehaviour {

	[SerializeField]
	float moveSensitivity = .5f;

	[SerializeField]
	private float smoothTime = 0.3f;

	private float velocity = 0;

	[SerializeField]
	private GameObject lasetBullet;

	[SerializeField]
	private Transform laserSpawnPoint;

	[SerializeField]
	private float laserRechargeRate = .5f;

	float rechargerCounter = 0;

	bool charged = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 difV = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = (180 / Mathf.PI) * Mathf.Atan2(difV.y, difV.x) -90; // convert radian to degrees
		//Debug.Log(difV + ", " + angle);
		//transform.rotation.eulerAngles.z = 
		//transform.rotation = Quaternion.Euler(0,0, Mathf.SmoothDamp(transform.rotation.eulerAngles.z, angle, ref velocity, smoothTime));
		transform.rotation = Quaternion.Euler(0, 0, angle);
    } 

	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal") ;
		float vertical = Input.GetAxis("Vertical");

		var rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.rotation * (new Vector2(horizontal, vertical)* moveSensitivity), ForceMode2D.Impulse);

		//GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up * 1f);

		if (Input.GetMouseButton(0) && charged)
		{
			charged = false;
			GameObject gb = GameObject.Instantiate(lasetBullet, laserSpawnPoint.position, transform.rotation) as GameObject;
		}

		if(!charged)
		{
			rechargerCounter += Time.deltaTime;

			if(rechargerCounter >= laserRechargeRate)
			{
				rechargerCounter = 0;
				charged = true;
			}
		}
	}
}
