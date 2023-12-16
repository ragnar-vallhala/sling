using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;



public class Test : MonoBehaviour
{
    [SerializeField] private float acceleration = 1.0f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject firePoint;
    [SerializeField] private float rateOfFire = 30.0f;
    [SerializeField] GameObject bullet;
    public static uint score = 0;


    private Rigidbody2D rb;
    private uint count = 0;
    private float lastFire = 0.0f;

    private void Awake()
    {
        score = 0;
    }


    void Start()
    {
         rb = player.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow)) {
            Vector2 move;
            move.x = 0.0f;
            move.y = acceleration * rb.mass;
            rb.position+= move * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 move;
            move.x = 0.0f;
            move.y = -acceleration * rb.mass;
            rb.position += move*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 move;
            move.y = 0.0f;
            move.x = -acceleration * rb.mass;
            rb.position += move * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 move;
            move.y = 0.0f;
            move.x = acceleration * rb.mass;
            rb.position += move * Time.deltaTime;
        }

        if(transform.position.y<-4.5f)
            transform.position = new Vector3(transform.position.x,-4.5f,transform.position.z);
        else if(transform.position.y > 4.5f)
            transform.position = new Vector3(transform.position.x, 4.5f, transform.position.z);


        if (transform.position.x<-9)
            transform.position = new Vector3(-9f,transform.position.y, transform.position.z);
        else if(transform.position.x > 9)
            transform.position = new Vector3(9f, transform.position.y, transform.position.z);


        if (Input.GetKey(KeyCode.Space) && (Time.time-lastFire)>1.0/rateOfFire)
        {
            lastFire = Time.time;
            Instantiate(bullet, firePoint.transform.position , Quaternion.identity);
            count++;
            Debug.Log("Objects: " +  count.ToString());
            Debug.Log(Time.time);

        }
    }
}
