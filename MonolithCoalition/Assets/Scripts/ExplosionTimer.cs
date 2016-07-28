using UnityEngine;
using System.Collections;

public class ExplosionTimer : MonoBehaviour {

	[SerializeField]
	float lifeDuration = 5f;

	float lifeTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime += Time.deltaTime;

		if (lifeTime >= lifeDuration)
		{
			Destroy(gameObject);
		}
	}
}
