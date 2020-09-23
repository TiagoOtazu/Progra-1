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
        Debug.Log("el enemy choco con algo");
        playerlife = collision.GetComponent<LifeManager>();
        if (playerlife != null)
        {
            try
            {
                playerlife.GetDamage(damage);
                Debug.Log("Funco el GetDamage a Player");
            }
            catch
            {
                Debug.Log("No Funco el GetDamage a Player");
                Exception E;
            }
        }
    }
}