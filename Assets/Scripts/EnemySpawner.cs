using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] float spawnInterval= 0.5f;

    [SerializeField] int maxEnemies= 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy()
    {
        int enemySpawned= 0;

        while(enemySpawned < maxEnemies)
        {
        yield return new WaitForSeconds(spawnInterval);
        GameObject newEnemy= Instantiate(enemyPrefab, new Vector2(Random.Range(-5,5), Random.Range(-5, 5)), Quaternion.identity);
        enemySpawned++;
        }
    }
}
