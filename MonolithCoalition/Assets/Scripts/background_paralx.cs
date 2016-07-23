using UnityEngine;
using System.Collections;

public class background_paralx : MonoBehaviour {

	Camera main;

	[SerializeField]
	public float paralaxFactor = 0.01f;

	Vector3 paralaxPos = Vector3.zero;

	Vector3 staticPos;

	// Use this for initialization
	void Start () {
		main = Camera.main;
		staticPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		//offset 

		paralaxPos = main.transform.position  - main.transform.position* paralaxFactor;

		transform.position = staticPos +  paralaxPos;
	}
}
