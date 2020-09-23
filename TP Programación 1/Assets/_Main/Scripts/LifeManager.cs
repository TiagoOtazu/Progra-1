using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] private float maxLife;
    private float currentLife;
    private Animator animatorController;

    private CharacterInput characterinputScript;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    private void Awake()
    {
        animatorController = GetComponent<Animator>();
        characterinputScript = GetComponent<CharacterInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage)
    {
        if (currentLife > 0)
        {
            currentLife -= damage;
            Debug.Log("Get Damage del player, currentLife: " + currentLife);
            if (currentLife <= 0)
            {
                animatorController.SetTrigger("Died"); 
                animatorController.SetBool("IsRunning", false);
                characterinputScript.GetKilled();
            }
            else
            {
                animatorController.SetTrigger("GetHitted");
            }   
        }
    }
}
