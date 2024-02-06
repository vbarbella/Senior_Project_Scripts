using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing_Movement_2 : MonoBehaviour
{
    public GameObject[] spawnObjects;

    void Start()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        print(Time.time);
        yield return new WaitForSeconds(Random.Range(3,7));
        SpawnClothing();
    }

    public void SpawnClothing()
    {
        Instantiate(spawnObjects[Random.Range(0,spawnObjects.Length)], this.transform);
        StartCoroutine(StartGame());
    }
}
