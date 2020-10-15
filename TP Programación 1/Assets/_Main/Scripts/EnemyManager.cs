using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
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
    }
    public void GetDamage(float damage)
    {
        if (currentLife > 0)
        {
            Debug.Log("Get Damage del enemy");
            currentLife -= damage; 
            Debug.Log("enemy Life: " + currentLife);
            if (currentLife <= 0)
            {
                animatorController.SetBool("Dead", true);
                characterinputScript.GetKilled();
            }
            else
            {
                animatorController.SetTrigger("GetHitted");
            }   
        }
    }
}