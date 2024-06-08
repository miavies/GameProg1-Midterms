using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCounter : MonoBehaviour
{
    public TextMeshProUGUI eggCountText, chickCountText, henCountText, roosterCountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEggCount();
        UpdateChickCount();
        UpdateHenCount();
        UpdateRoosterCount();
    }

    void UpdateEggCount()
    {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");
        int eggCount = eggs.Length;
        eggCountText.text = "Eggs: " + eggCount.ToString();
    }

    void UpdateChickCount()
    {
        GameObject[] chicks = GameObject.FindGameObjectsWithTag("Chick");
        int chickCount = chicks.Length;
        chickCountText.text = "Chicks: " + chickCount.ToString();
    }

    void UpdateHenCount()
    {
        GameObject[] hens = GameObject.FindGameObjectsWithTag("Hen");
        int henCount = hens.Length;
        henCountText.text = "Hens: " + henCount.ToString();
    }

    void UpdateRoosterCount()
    {
        GameObject[] roosters = GameObject.FindGameObjectsWithTag("Rooster");
        int roosterCount = roosters.Length;
        roosterCountText.text = "Roosters: " + roosterCount.ToString();
    }




}
