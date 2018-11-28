using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int _playerHealth;

    public void PlayerHurt(int damage)
    {
        if (_playerHealth > 0)
        {
            _playerHealth -= damage;
            Debug.Log("PlayerHealth: " + _playerHealth);
        }
    }

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerHealth <= 0)
        {
            //Destroy(gameObject);
            Debug.Log("YOU LOST");
        }
    }
}