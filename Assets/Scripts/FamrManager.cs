using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamrManager : MonoBehaviour
{
    public int eggCount, chickCount, henCount, roosterCount;
    public GameObject hen;
    public ObjectCounter objectCounter;

    void Start()
    {
        objectCounter = FindObjectOfType<ObjectCounter>();
    }

// Update is called once per frame
void Update()
    {
        eggCounter();
        chickCounter();
        henCounter();
        roosterCounter();

        if (eggCount == 0 && chickCount == 0 && henCount == 0)
        {
            TransformRoosterToHen();
        }
    }

    void TransformRoosterToHen()
    {
        if (roosterCount > 0)
        {
            GameObject rooster = GameObject.FindWithTag("Rooster");

            Vector3 position = rooster.transform.position;
            Quaternion rotation = rooster.transform.rotation;

            Destroy(rooster);
            
            GameObject newHen = Instantiate(hen, position, rotation);
            henCount++;
        }
    }

    int eggCounter()
    {
        if (int.TryParse(objectCounter.eggCountText.text.Split(':')[1].Trim(), out eggCount))
        {
            return eggCount;
        }
        else
        {
            return 0;
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
    int roosterCounter()
    {
        if (int.TryParse(objectCounter.roosterCountText.text.Split(':')[1].Trim(), out roosterCount))
        {
            return roosterCount;
        }
        else
        {
            return 0;
        }
    }

}