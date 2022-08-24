using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class finishmoneyrortate : MonoBehaviour
{
    public GameObject yourgameobject;
    public Transform target;
    public Camera cam;
   


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            yourgameobject.transform.DORotate(new Vector3(-90, 0, 0),0.60f);
            target.transform.position = new Vector3(-10, -1, -50);
            Debug.Log("win");                               
            cam.gameObject.SetActive(true);
        }
    }
}

