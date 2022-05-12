using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            Debug.Log("Monster spotted");
        }

        if (collision.gameObject.tag == "Entity")
        {
            Debug.Log("Entity spotted");
        }
    }
}
