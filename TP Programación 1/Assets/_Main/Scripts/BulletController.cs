using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;

    private Transform player;

    private Vector2 target;
    
    public LifeManager CharacterLife;
    [SerializeField] private float damage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("choco con esqueleto");
        CharacterInput player = collision.GetComponent<CharacterInput>();
        CharacterLife = collision.GetComponent<LifeManager>();
        if (player != null)
        {
            try
            {
                CharacterLife.GetDamage(damage);
            //    Debug.Log("Si Funca Invocacion a GetDamage");
            }
            catch
            {
              //  Debug.Log("No Funca Invocacion a GetDamage");
                Exception E;
            }

            Destroy(gameObject);
        }
    }
    }