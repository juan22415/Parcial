using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generate : MonoBehaviour
{

    [SerializeField]
    private GameObject crystal;
    private Transform transform;

    public int currentcrystas;


    private void Awake()
    {
        transform = GetComponent<Transform>();
    }

    public void Generatenewcrystal()
    {
        Vector3 position = new Vector3(Random.Range(-9, 9), Random.Range(-5,5), 0);
        Debug.Log(position);
        transform.position = position;
        setcurrentcrystals();
        Instantiate(crystal,transform);
    }

    private void setcurrentcrystals()
    {
        currentcrystas++;

        if (currentcrystas > 5)
        {
            Debug.Log("ganaste");
        }
    }
}
