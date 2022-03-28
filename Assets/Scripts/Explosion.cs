using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject effect;

    private void OnDisable()
    {
        Instantiate(effect, transform.position, transform.rotation);
    }
}
