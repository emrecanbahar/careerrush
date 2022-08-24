using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teeen : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject gameoverr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game.monney -= 10;
            game.money_text.text = game.monney.ToString();
            Debug.Log("teen");
        }else if (game.monney < 0)
        {
            gameoverr.SetActive(true);
            
        }
           

    }
}
