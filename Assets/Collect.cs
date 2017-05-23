using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    public Generate generate;
    public GameObject generator;
    // Use this for initialization
    void Start()
    {
        generator = GameObject.Find("Crystalsmaager");
        generate = generator.GetComponent<Generate>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        generate.Generatenewcrystal();
        Destroy(gameObject);

    }


}
