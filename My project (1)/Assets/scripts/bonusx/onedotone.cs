using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onedotone : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject nextlevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
            game.monney *=1.1;
            game.money_text.text = game.monney.ToString();
            Debug.Log("onedorone");
            nextlevel.SetActive(true);
        }
    }  
}
