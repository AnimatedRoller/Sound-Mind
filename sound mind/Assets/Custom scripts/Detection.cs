using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Detection : MonoBehaviour
{

    
     void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.tag == "Fish")
        {
            
            
            Debug.Log("Fish spotted: " );
        }

        if (collision.gameObject.tag == "Monster")
        {
            Debug.Log("Monster spotted");
        }

        if (collision.gameObject.tag == "Entity")
        {
            Debug.Log("Entity spotted");
        }
    }
}
