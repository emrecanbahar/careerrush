using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesftrotate : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.Rotate(0,-90,0);
            
        }
    }
}

