using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creation : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    public Transform spawner;

    public Button npc1;
    public Button npc2;
    public Button npc3;

    // Start is called before the first frame update
    void Start()
    {
        npc1.onClick.AddListener(delegate { Create(NPC1); });
        npc2.onClick.AddListener(delegate { Create(NPC2); });
        npc3.onClick.AddListener(delegate { Create(NPC3); });
    }

    void Create(GameObject name)
    {
        GameObject go = Instantiate(name) as GameObject;
        go.transform.position = spawner.position;
    }
}
