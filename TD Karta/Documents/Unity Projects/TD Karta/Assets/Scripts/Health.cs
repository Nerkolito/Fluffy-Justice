using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float _health;
    public float enemyMaxhealth;
    //public int _playerHealth;
    public Slider healthBar;
    

    public void Hurt(int damage)
    {
       

        _health -= damage;
        Debug.Log("Health: " + _health);
        healthBar.value = _health;

    }
    

    
  

    /*public void PlayerHurt(int playerDamage)
    {
        _playerHealth -= playerDamage;
        Debug.Log("Health: " + _health);
    }*/

    // Use this for initialization
    void Start()
    {
        enemyMaxhealth = _health;
        healthBar.value = enemyMaxhealth;
     
        //_playerHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = _health;
      
        if (_health <= 0)
        {
            Destroy(gameObject, 0.1f);
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<EnemyWalk>().speed = 0.0f;
        }
        /*if (_playerHealth <= 0)
        {
            Debug.Log("YOU LOST");
        }*/
    }
}
