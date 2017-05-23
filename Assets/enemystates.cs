using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemystates : MonoBehaviour {


    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        rigidbody.velocity=(new Vector2 (-5, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            rigidbody.velocity = (new Vector2(-1*rigidbody.velocity.x, 0));
        }
    }
}
