    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] GameObject enemyPrefab;

        [SerializeField] float spawnInterval= 0.5f;

        [SerializeField] int maxEnemies= 5;

        public GameObject[] enemies;

        // Start is called before the first frame update
        void Start()
        {
            enemies= new GameObject[maxEnemies];

            StartCoroutine(spawnEnemy());
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private IEnumerator spawnEnemy()
        {
            
            for(int i= 0; i < maxEnemies; i++)
        {
            yield return new WaitForSeconds(spawnInterval);
            GameObject newEnemy= Instantiate(enemyPrefab, new Vector2(Random.Range(-5,5), Random.Range(-5, 5)), Quaternion.identity);
            enemies[i]= newEnemy;

            newEnemy.name= "Enemy: " +i;
        }
            
        }
    }
