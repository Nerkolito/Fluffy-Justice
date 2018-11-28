using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    public float MeleeDmg;
    public float MeleeTimer;


    void Start()
    {
        if (MeleeTimer > 0)
        {
            MeleeTimer -= MeleeDmg;
        }

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (MeleeTimer <= 1)
            {
                other.GetComponent<Health>().Hurt(1);
                Debug.Log("TEST");
            }
        }
    }
}
