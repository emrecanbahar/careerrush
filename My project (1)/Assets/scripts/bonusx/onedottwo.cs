using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onedottwo : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject nextlevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game.monney *= 1.2;
            game.money_text.text = game.monney.ToString();
            Debug.Log("ondortwo");
            nextlevel.SetActive(true);
        }
    }  
}
