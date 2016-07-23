using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	[SerializeField]
	private Transform target;

	[SerializeField]
	private float smoothTime = 0.3f;

	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

		if (hit.collider != null)
		{
			//Debug.Log("Hit" + hit.transform.gameObject.name);
		}
	}

	void FixedUpdate()
	{
		Vector3 targetPos = target.transform.position + Vector3.forward * Camera.main.transform.position.z;
		transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
	}
}
