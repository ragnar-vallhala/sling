using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float life = 5.0f;


    void Awake()
    {
        Destroy(gameObject, life);


        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
            rb.velocity = - speed * Vector3.up;
        else
            Debug.Log("WTF! Where is rb?");

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                Destroy(gameObject);
                Test.score++;
            }

            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                SceneManager.LoadScene(1);

            }
            if (collision.gameObject.CompareTag("End"))
            {
                Destroy(gameObject);
                SceneManager.LoadScene(1);

            }

        }

    }



}
