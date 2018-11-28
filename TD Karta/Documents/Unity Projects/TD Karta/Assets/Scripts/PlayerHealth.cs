using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int _playerHealth;
    [SerializeField] GameObject player;
    //[SerializeField] GameObject bigEnemy;

    public void PlayerHurt(int damage)
    {
        if (_playerHealth <= 0)
        {
            _playerHealth = 0;
            //Destroy(gameObject);
            Debug.Log("YOU LOST AND YOU SUCK");
        }
        else if (_playerHealth > 0)
        {
            _playerHealth -= damage;
            Debug.Log("PlayerHealth: " + _playerHealth);
        }
    }

    // Use this for initialization
    void Start()
    {
        _playerHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
