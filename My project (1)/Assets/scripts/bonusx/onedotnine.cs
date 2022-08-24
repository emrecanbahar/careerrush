
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onedotnine : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject nextlevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game.monney *= 1.9;
            game.money_text.text = game.monney.ToString();
            nextlevel.SetActive(true);
        }
    }  
}
