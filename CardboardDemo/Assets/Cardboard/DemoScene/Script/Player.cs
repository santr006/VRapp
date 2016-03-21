using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 1.0f;

    private Cardboard cardboard;
    private GameObject camera;
    private Rigidbody rb;

    private bool walking = false;
    private bool collided = false;



    private Vector3 lastPos;

	// Use this for initialization
	void Start () {
        cardboard = GetComponent<Cardboard>();
        camera = transform.GetChild(0).GetChild(0).gameObject;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    void Update()
    {
        //walk
        if (walking)
        {
            Debug.Log("walking");
            rb.velocity = camera.transform.forward * speed;            
        }
        else
        {
            rb.velocity = new Vector3(0,0,0); 
        }

        //start/stop walking
        if (cardboard.Triggered)
        {
            if (walking)
            {
                walking = false;
            }
            else
            {
                walking = true;
            }            
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        collided = true;
        Debug.Log("collision");
    }
}
