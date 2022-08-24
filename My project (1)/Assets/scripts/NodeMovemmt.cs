using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;


public class NodeMovemmt : MonoBehaviour
{
    public Transform placeHolder;
    
    public moneytextmanager game;
    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            transform.parent = placeHolder; 
            transform.DOLocalJump(placeHolder.GetChild(placeHolder.parent.GetComponent<CollectControl>().pointer).localPosition, 0.1f, 1, 1);            
            placeHolder.parent.GetComponent<CollectControl>().pointer++;
            game.monney ++;
            game.money_text.text = game.monney.ToString();


            Debug.Log("pointer");
          
        } 
        
       
    }







}

    





   







