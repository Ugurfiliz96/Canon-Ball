using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathball : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ball" || collision.gameObject.tag=="pivot")
        {
            Destroy(collision.gameObject,1f);
        }
    }
}
