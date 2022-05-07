using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthManager : MonoBehaviour
{
    static int depth = 0;
    static int sanity = 100;
    static int infoGathered = 0;

    void Start()
    {
        InvokeRepeating("depthChange", 60, 60);
        InvokeRepeating("sanityChange", 30, 30);
    }
    void depthChange()
    {
        depth += 10;
        Debug.Log(depth.ToString());
    }
    void sanityChange()
    {
        sanity -= 3;
        Debug.Log(sanity.ToString());
    }
}
