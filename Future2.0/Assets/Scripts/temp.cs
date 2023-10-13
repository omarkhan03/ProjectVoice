using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{

    public Transform nucleus;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = nucleus.position;
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
