using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEgg : MonoBehaviour
{
    
    public GameObject egg;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject instantiatedEgg = Instantiate(egg, transform.position, transform.rotation);
    }
}
