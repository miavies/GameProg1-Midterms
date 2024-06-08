using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggToChick : MonoBehaviour
{
    public float timerTime, hatchTime;
    public GameObject egg, chick;
    private bool chickHatched;

    // Start is called before the first frame update
    void Start()
    {
        timerTime = 0f;
        chickHatched = false;
    }

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        eggToChick();
    }

    void eggToChick()
    {
        if (!chickHatched && timerTime >= hatchTime)
        {
            GameObject instantiatedChick = Instantiate(chick, transform.position, transform.rotation);
            Destroy(egg);
            chickHatched = true;
        }
    }
}
