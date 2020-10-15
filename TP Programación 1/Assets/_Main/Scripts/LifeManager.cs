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
    void Start()
    {
        currentLife = maxLife;
    }
    private void Awake()
    {
        animatorController = GetComponent<Animator>();
        characterinputScript = GetComponent<CharacterInput>();
    }
    public void GetDamage(float damage)
    {
        Debug.Log("GetDamage del Player");
        if (currentLife > 0)
        {
            currentLife -= damage;
            Debug.Log("currentLife: " + currentLife);
            if (currentLife <= 0)
            {
                Debug.Log("Murio el player");
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
