using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool haspackage;
    [SerializeField] float destroydelay = 0.2f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ups..!");   
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !haspackage)
        {
            Debug.Log("Package picked up!");
            haspackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroydelay);

        }
        else if (other.tag == "Customer" && haspackage)
        {
            Debug.Log("Package delivered to the customer!");
            haspackage = false;
            spriteRenderer.color = noPackageColor;
        }
            
    }
}
