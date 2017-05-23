using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour {

    private Vector3 touchposition;
    private Rigidbody2D m_rigidbody;
    private float aceleration;

    public float referenceaceleration;
    public float maxspeed;


    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            m_rigidbody.velocity = Vector2.zero;
            touchposition=Input.mousePosition;
            touchposition.z = 10;
            touchposition = Camera.main.ScreenToWorldPoint(touchposition);

            Movetotouch(touchposition);
        }

        if (m_rigidbody.velocity.magnitude > maxspeed)
        {
            m_rigidbody.velocity = m_rigidbody.velocity.normalized * maxspeed;
        }
         
	}

    private void Movetotouch(Vector3 touchposition)
    {
        
        Vector3 direction = touchposition - transform.position;
        aceleration =setaceleration(direction);
        direction*= aceleration;
        m_rigidbody.AddForce(direction);
    }

    private float setaceleration(Vector3 direction)
    {
        float magnitud =direction.magnitude;
        aceleration=referenceaceleration * magnitud;
        return aceleration;
    }
}
