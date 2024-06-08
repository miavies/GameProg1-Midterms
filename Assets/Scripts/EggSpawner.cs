using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public float timerTime, layEggTime;
    public GameObject egg;
    private bool henLayedEgg;
    void Start()
    {
        timerTime = 0f;
        henLayedEgg = false;
    }
    void Update()
    {
        timerTime += Time.deltaTime;
        spawnEgg();
    }
    public void spawnEgg()
    {
        if (!henLayedEgg && timerTime >= layEggTime)
        {
            float randomNum = Random.Range(2, 11);
            
            for (int i = 0; i < randomNum; i++)
            {
                GameObject instantiatedEgg = Instantiate(egg, transform.position, transform.rotation);
                henLayedEgg = true;
            }
        }
            
    }
}
