using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthManager : MonoBehaviour
{
    static int depth = 0;
    static int sanity = 100;
    static int infoGathered = 0;
    GameObject darkness = GameObject.Find("DarknessOverlay");
    //*Color tmp = darkness.GetComponent<SpriteRenderer>().color;
    //*tmp.a = 0f;

    void Start()
    {
        InvokeRepeating("depthChange", 10, 10);
        InvokeRepeating("sanityChange", 30, 30);
    }
    void depthChange()
    {
        depth += 10;
        Debug.Log(depth.ToString());
        //*tmp.a += 5f;
        //*darkness.GetComponent<SpriteRenderer>().color = tmp;
    }
    void sanityChange()
    {
        sanity -= 3;
        Debug.Log(sanity.ToString());
    }
}
