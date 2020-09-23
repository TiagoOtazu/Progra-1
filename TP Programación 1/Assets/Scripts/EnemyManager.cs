using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage)
    {
        if (currentLife > 0)
        {
          //  Debug.Log("Fue invocado Get Damage");
            currentLife -= damage;
          //  Debug.Log("currentLife: " + currentLife);
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
