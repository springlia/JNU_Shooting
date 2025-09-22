using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    const float minTime = 1;
    const float maxTime = 5;

    [SerializeField] GameObject enemyFactory;
    float currentTime;
    [SerializeField] float createTime = 1;


    void Start()
    {
        //StartCoroutine(SpawnEnemy());
        createTime = Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = this.transform.position;
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }

    }

    //IEnumerator SpawnEnemy()
    //{
    //    while (true)
    //    {
    //        float time = Random.Range(1, 5);
    //        float xPos = Random.Range(-3, 3);
    //        yield return new WaitForSeconds(time);
    //        GameObject enemy = Instantiate(enemyFactory);
    //        enemy.transform.position = new Vector3(xPos, 4, 0);
    //    }
    //}
}
