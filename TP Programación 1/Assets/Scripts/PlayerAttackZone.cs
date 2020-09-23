using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackZone : MonoBehaviour
{

    private bool estoyAtacando;
    public EnemyManager enemy; 
   [SerializeField] private float damage;

   // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Awake()
    {
        estoyAtacando = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter");
        eventoAtaque(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay, estoyAtando:" + estoyAtacando);
        if (!estoyAtacando)
        {
            Debug.Log("Ataque en OnTriggerStay");
            eventoAtaque(collision);            
        }
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        estoyAtacando = false;
    }

    private void eventoAtaque(Collider2D collision)
    {
        estoyAtacando = true;
        Debug.Log("Puede Atacar:" + estoyAtacando);
        enemy = collision.GetComponent<EnemyManager>();
        if (enemy != null)
        {
            try
            {
                enemy.GetDamage(damage);
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