using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickToAdult : MonoBehaviour
{
    public float timerTime, chickGrowTime;
    public int chickCount, henCount;
    public GameObject chick, hen, rooster;
    private bool chickGrewToAdult;
    public ObjectCounter objectCounter;
    // Start is called before the first frame update
    void Start()
    {
        timerTime = 0f;
        chickGrewToAdult = false;
        objectCounter = FindObjectOfType<ObjectCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        chickToAdult();
        chickCounter();
        henCounter();
    }

    void chickToAdult()
    {
        if (!chickGrewToAdult && timerTime >= chickGrowTime)
        {
            float randomNum = Random.Range(1, 11);
            
            if (henCount == 0 && chickCount < 2)
            {
                GameObject instantiatedHen = Instantiate(hen, transform.position, transform.rotation);
            }
            else if (randomNum%2 == 0)
            {
                GameObject instantiatedHen = Instantiate(hen, transform.position, transform.rotation);
            }
            else if (randomNum != 0)
            {
                GameObject instantiatedRooster = Instantiate(rooster, transform.position, transform.rotation);
            }

            Destroy(chick);
            chickGrewToAdult = true;
        }
    }

    int chickCounter()
    {
        if (int.TryParse(objectCounter.chickCountText.text.Split(':')[1].Trim(), out chickCount))
        {
            return chickCount;
        }
        else
        {
            return 0;
        }
    }
    int henCounter()
    {
        if (int.TryParse(objectCounter.henCountText.text.Split(':')[1].Trim(), out henCount))
        {
            return henCount;
        }
        else
        {
            return 0;
        }
    }
}
