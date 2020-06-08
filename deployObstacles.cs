using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, screenBounds.y);
    }
    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}