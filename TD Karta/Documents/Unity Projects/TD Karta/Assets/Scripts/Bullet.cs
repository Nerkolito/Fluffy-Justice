using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bullet : MonoBehaviour
{
    [SerializeField]
    private GameObject explosion;
    [SerializeField]
    private float size;
    int damage = 1;
    void Start()
    {
        GetComponent<Transform>().localScale += new Vector3(size, size, size)/4;
        GetComponent<Rigidbody>().velocity = transform.forward * 8;
    }
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        Health health = other.collider.GetComponent<Health>();
        
        if (health != null)
        {
            health.Hurt(damage);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}