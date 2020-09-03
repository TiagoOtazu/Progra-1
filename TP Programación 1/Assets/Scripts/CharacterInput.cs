using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterInput : MonoBehaviour
{
    /*
    [SerializeField] private string leftKey;
    private bool leftCondition;
    [SerializeField] private string rightKey;
    private bool rightCondition;
    [SerializeField] private string attackKey;
    private bool attackCondition;
    [SerializeField] private string jumpKey;
    private bool jumpCondition;
    */

    [SerializeField] private float speed = 1;

    void Start()
    {
/*
Se termino resolviendo de otra forma, pero la idea es utiliarlo
        leftKey = "a";
        rightKey = "d";
        jumpKey = " ";
        attackKey = "t";
*/
        
    }
    void Update()
    {

        float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(xMovement, 0f, 0f);
        /*
        leftCondition = Input.GetKey(KeyCode.A);
        rightCondition = Input.GetKey(KeyCode.D);
        jumpCondition = Input.GetKey(KeyCode.Space);
        attackCondition = Input.GetKey(KeyCode.K);
        bool keyRightDown = Input.GetKeyDown(KeyCode.D);
        bool keyLeftDown = Input.GetKeyDown(KeyCode.A);
        if (leftCondition)
        {
            /*float XAxis = 1 * -speed * Time.deltaTime;
            transform.Translate(new Vector3(XAxis, 0, 0)); 
        }
        if (attackCondition)
        {
            Debug.Log("Evento ataque");            
        }
        if (jumpCondition)
        {
            Debug.Log("Evento Salto");
        }
        if (rightCondition)
        {
            float XAxis = 1 * speed * Time.deltaTime;
            transform.Translate(new Vector3(XAxis, 0, 0));
        }
        if (keyRightDown && this.transform.rotation.y != 180)
        {
            transform.Rotate(0,180,0);
        }

        if (keyLeftDown && this.transform.rotation.y != 0)
        {
            transform.Rotate(0,180,0);
        }
        */
    }

    void Awake()
    {
    }
    private void MoveLeft()
    {}
    private void MoveRight()
    {}
    private void Jump()
    {}
    private void Attack()
    {
        
    }
}
