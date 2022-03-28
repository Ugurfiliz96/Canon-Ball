using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPivot : MonoBehaviour
{
    [SerializeField] Rigidbody TargetPivot;
    [SerializeField] bool touch = false;
    [SerializeField] GameObject ball;

    private void Update()
    {
        if (touch==true)
        {
            TargetPivot.isKinematic = false;
            
        }    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ball")
        {
            touch = true;
            Destroy(collision.gameObject);
        }
    }

 
}
