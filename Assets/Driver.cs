using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerspeed = 0.2f;
    [SerializeField] private float movingspeed = 20f;
    [SerializeField] private float slowspeed = 15f;
    [SerializeField] private float boostspeed = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
            movingspeed = boostspeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        movingspeed = slowspeed;
    }

    // Update is called once per frame
    void Update()
    {

        float steeramount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float movingamount = Input.GetAxis("Vertical") * movingspeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0, movingamount, 0);
        
        
    }
}
