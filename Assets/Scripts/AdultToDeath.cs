using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultToDeath : MonoBehaviour
{
    public float timerTime, deathTime;
    public GameObject hen, rooster;
    private bool adultDied;
    // Start is called before the first frame update
    void Start()
    {
        timerTime = 0f;
        adultDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        adultDeath();
    }

    void adultDeath()
    {
        if (!adultDied && timerTime >= deathTime)
        {
            Destroy(hen);
            Destroy(rooster);
            adultDied = true;
        }
    }
}
