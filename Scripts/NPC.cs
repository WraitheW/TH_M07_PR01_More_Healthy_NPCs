using System;
using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

}
