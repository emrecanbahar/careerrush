using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public  float movemsped;
    public   float harspeed;
    private Animator animator;
   
    public moneytextmanager game;
    float har;


    
   public  void Update()
    {
        har = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(har * harspeed * Time.deltaTime, 0, movemsped * Time.deltaTime));
       
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Door"))
        {
            game.monney+=10;
            game.money_text.text = game.monney.ToString();
        }
        else if (other.gameObject.CompareTag("NegativeDoor"))
        {
            game.monney-=10;
            game.money_text.text = game.monney.ToString();
        } else if(other.gameObject.CompareTag("finish"))
        {
            animator.SetBool("push", true);
        }
        else if (other.gameObject.CompareTag("ýdlee"))
        {
            animator.SetBool("ýdle", true);
            Time.timeScale = 0f;
        }

    }
}
