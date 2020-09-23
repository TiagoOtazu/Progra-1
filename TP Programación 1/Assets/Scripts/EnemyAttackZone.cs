using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAttackZone : MonoBehaviour
{

    
    public LifeManager playerlife; 
    [SerializeField] private float damage;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        eventoAtaque(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
     //   eventoAtaque(collision);
    }

    private void eventoAtaque(Collider2D collision)
    {
        Debug.Log("Choco con algo");
        playerlife = collision.GetComponent<LifeManager>();
        if (playerlife != null)
        {
            try
            {
                playerlife.GetDamage(damage);
                //  Debug.Log("Si Funca Invocacion a GetDamage");
            }
            catch
            {
                // Debug.Log("No Funca Invocacion a GetDamage");
                Exception E;
            }
        }
    }
}