using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenmoney : MonoBehaviour
{
    public moneytextmanager game;
    public GameObject nesne;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject yeni_nesne = Instantiate(nesne);// Sahneye nesne eklenir.
            yeni_nesne = Instantiate(nesne, new Vector3(15, 1, -2),Quaternion.identity);
            yeni_nesne.gameObject.GetComponent<BoxCollider>().enabled = true;
            game.monney += 10;
            game.money_text.text = game.monney.ToString();
            Debug.Log("teen");
        }
        
    }
}
