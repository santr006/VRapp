using UnityEngine;
using System.Collections;

public class Spirit : MonoBehaviour {

	public float radius = 3.0f;
    public float speed = 1.0f;
    public float height = 1.0f;

	// Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, height, radius);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Cos(Time.time * speed) * radius, height, Mathf.Sin(Time.time * speed) * radius);
	}
}
