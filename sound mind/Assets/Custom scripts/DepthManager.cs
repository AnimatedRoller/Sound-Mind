using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;

public class DepthManager : MonoBehaviour
{
    public int depth = 0;
    public int sanity = 100;
    public int infoGathered = 0;
    private const double V = 0.1;
    public float darken = (float)V;

    public GameObject darkness = GameObject.Find("OceanLight");
    public GameObject JB = GameObject.Find("journal backdrop");

    void Start()
    {         
        InvokeRepeating("depthChange", 10, 10);           
        InvokeRepeating("sanityChange", 30, 30);
    }
    void depthChange()
    {
        depth += 50;
        Debug.Log("depth of " + depth.ToString() + " Reached");

        darkness.GetComponent<Light2D>().intensity -= darken;
    }
    void sanityChange()
    {
        sanity -= 3;
        Debug.Log("Your sanity has decreased to " + sanity.ToString());

        if (sanity <= 100 && sanity > 75)
        {
            JB.GetComponent<Sequencer>().SetStep(1);
        }

        if (sanity <= 75 && sanity > 50)
        {
            JB.GetComponent<Sequencer>().SetStep(1);
        }

        if (sanity <= 50 && sanity > 25)
        {
            JB.GetComponent<Sequencer>().SetStep(2);
        }

        if (sanity <= 25 && sanity > 0)
        {
            JB.GetComponent<Sequencer>().SetStep(3);
        }

    }


}