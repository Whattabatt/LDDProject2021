using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = .1f;

    float rotation = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        updatePosition();

    }
    public static Vector2 rotate(Vector2 v, float delta)
    {
        delta *= Mathf.Deg2Rad;
        return new Vector2(
            v.x * Mathf.Cos(delta) - v.y * Mathf.Sin(delta),
            v.x * Mathf.Sin(delta) + v.y * Mathf.Cos(delta)
        );
    }

    private void updatePosition()
    {

        Vector2 deltaVector = new Vector2(0,Input.GetAxis("Vertical"));

        deltaVector = .2f*speed*rotate(deltaVector, rotation);

        transform.Translate(deltaVector);

        transform.Rotate(0,0,-1*Input.GetAxis("Horizontal"));
                       
        rotation += .2f * speed *Input.GetAxis("Horizontal");
        Debug.Log(rotation);
    }
}
