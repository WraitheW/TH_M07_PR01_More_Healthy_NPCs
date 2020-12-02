using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public GameObject[] npc1;
    public GameObject[] npc2;
    public GameObject[] npc3;

    // Update is called once per frame
    void Update()
    {
        npc1 = GameObject.FindGameObjectsWithTag("NPC1");
        npc2 = GameObject.FindGameObjectsWithTag("NPC2");
        npc3 = GameObject.FindGameObjectsWithTag("NPC3");

        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (GameObject go in npc2)
            {
                go.GetComponent<NPC>().TakeDamage(10);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (GameObject go in npc1)
            {
                go.GetComponent<NPC>().TakeDamage(5);
            } 
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            foreach (GameObject go in npc3)
            {
                go.GetComponent<NPC>().TakeDamage(0);
            }
        }
    }
}
