using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f; 


    void Awake()
    {
        Destroy(gameObject, 2.0f);

        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
            rb.velocity = speed * Vector3.up;
        else
            Debug.Log("WTF! Where is rb?");
        
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
           
            if (collision.gameObject.CompareTag("Enemy"))
                Destroy(gameObject);
        }
        
    }
}
