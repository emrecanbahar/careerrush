using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overmoney : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject gameoverr;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            
            other.GetComponent<CollectControl>().pointer--;
            Debug.Log("overmoney");
            game.monney--;
            game.money_text.text = game.monney.ToString();
        }
        else if (game.monney < 0)
        {
            gameoverr.SetActive(true);
        }
    }
  
}
