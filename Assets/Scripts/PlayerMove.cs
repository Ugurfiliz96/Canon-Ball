using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform player;

    public float speed;
    void Start()
    {
        player = GetComponent<Transform>();
    }

   
    void Update()
    {
        player.Translate(Vector3.forward * speed*Time.deltaTime);
    }
}
