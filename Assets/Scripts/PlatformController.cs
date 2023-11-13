using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Transform platform1;
    public Transform platform2;
    public Transform temp1;
    public Transform temp2;
    

    private void Start()
    {
        
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Temp1"))
        {
           
            platform1.position = temp2.position;

        }
        if (other.gameObject.CompareTag("Temp2"))
        {
       
            platform2.position = temp1.position;
        }
    }
}


