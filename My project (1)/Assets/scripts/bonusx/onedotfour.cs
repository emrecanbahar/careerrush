using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onedotfour : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject nextlevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game.monney *= 1.4;
            game.money_text.text = game.monney.ToString();
            nextlevel.SetActive(true);
        }
    }  
}
