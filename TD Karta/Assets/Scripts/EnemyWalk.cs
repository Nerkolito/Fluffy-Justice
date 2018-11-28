﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    
    public float speed;
    private Transform target;
    private int wavePointIndex = 0;
    public int enemyDamage = 1;
    public GameObject player;

    void Start()
    {
        target = WayPoints.wP[0];
    }

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        //PlayerHealth player = GetComponent<PlayerHealth>();
        if (wavePointIndex >= WayPoints.wP.Length - 1)
        {
            Destroy(gameObject);
            //player.PlayerHurt(enemyDamage);
            player.GetComponent<PlayerHealth>().PlayerHurt(enemyDamage);
        }

        else if (wavePointIndex <= WayPoints.wP.Length - 1)
        {
            wavePointIndex++;
            target = WayPoints.wP[wavePointIndex];
        }
    }
}