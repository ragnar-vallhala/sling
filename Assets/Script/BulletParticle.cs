using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticle : MonoBehaviour
{


    [SerializeField] private GameObject flame;
    private float lastFlame = 0.0f;
    void Update()
    {
        if (Time.time - lastFlame > 0.4)
        {
            Transform tf = transform;
            tf.position = new Vector3(tf.position.x, tf.position.y-0.2f, tf.position.z);
            Instantiate(flame, gameObject.transform.position, Quaternion.identity).transform.SetParent(tf);
            lastFlame = Time.time;
        }
        
        
    }
}
