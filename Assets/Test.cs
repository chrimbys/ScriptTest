using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        int[] points = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}