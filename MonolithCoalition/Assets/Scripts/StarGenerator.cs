using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StarGenerator : MonoBehaviour {

    [SerializeField]
    GameObject[] stars;

    [SerializeField]
    GameObject Background;

    [SerializeField]
    float xMin;
    [SerializeField]
    float xMax;

    [SerializeField]
    float yMin;
    [SerializeField]
    float yMax;

    [SerializeField]
    int numberOfstars;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ClearStars()
    {
        foreach(Transform c in Background.transform)
        {
            DestroyImmediate(c.gameObject);
        }
    }

    public void GenerateStars()
    {
        
        for(int i = 0; i < numberOfstars; i++)
        {
            float randX = Random.Range(xMin, xMax);
            float randY = Random.Range(yMin, yMax);

            int randMag = Random.Range(0, 2);
			//float paralaxAmount = Random.Range(1 - (1f + randMag) * 0.2f, 1f - (randMag) * 0.2f);
			float paralaxAmount = Random.Range(1f, 0.6f);
			GameObject star = GameObject.Instantiate(stars[randMag]) as GameObject;
			star.GetComponent<background_paralx>().paralaxFactor = paralaxAmount;

			star.transform.SetParent(Background.transform);
            star.transform.position = new Vector3(randX, randY);
        }
    }
}
