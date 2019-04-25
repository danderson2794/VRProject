using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTracking : MonoBehaviour
{
    bool initialized = false;
    Vector3 lastPos = GameObject.Find("cube1").transform.position;

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = GameObject.Find("cube1").transform.position;
        if (curPos != lastPos)
        {
            print("Moving ");
        }
        lastPos = curPos;
    }
}
