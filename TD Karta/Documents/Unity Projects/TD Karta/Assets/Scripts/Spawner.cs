using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject bigEnemyPrefab;

    private GameObject _enemy;

    public float timer = 0f;
    public int enemyCount = 0;
    public int bigEnemyCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 1.0f)
        {
            timer += Time.deltaTime;
        }
        else if (enemyCount < 10 && timer >= 1.0f)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            enemyCount++;
            //StartCoroutine(SpawnerTimer());
            timer = 0f;
        }
        else if (bigEnemyCount < 5 && timer >= 1.0f)
        {
            _enemy = Instantiate(bigEnemyPrefab) as GameObject;
            bigEnemyCount++;
            timer = 0f;
        }
    }

    /*private IEnumerator SpawnerTimer()
    {
        bool spawn = true;
        if (spawn)
        { 
            yield return new WaitForSeconds(1f);
            _enemy = Instantiate(enemyPrefab) as GameObject;
            enemyCount++;
            spawn = false;
        }
    }*/
}