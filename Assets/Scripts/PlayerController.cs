using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = .1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        updatePosition();

    }

    private void updatePosition()
    {
        Vector2 newPosition = transform.position;

        newPosition.x -= speed * Input.GetAxis("Horizontal");
        newPosition.y -= speed * Input.GetAxis("Vertical");
        transform.position = newPosition;
    }
}
