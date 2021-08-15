using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    [SerializeField] private float xBounds = 15f;
    [SerializeField] private float zBounds = 15f;
    [SerializeField] private float startDelay = 1f;
    [SerializeField] private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnItems", startDelay, spawnInterval);
    }


    public void SpawnItems()
    {
        Vector3 pos = new Vector3(Random.Range(-xBounds, xBounds), 2, Random.Range(-zBounds, zBounds));
        Instantiate(items[Random.Range(0, items.Length)], pos, Quaternion.identity);
    }



}
