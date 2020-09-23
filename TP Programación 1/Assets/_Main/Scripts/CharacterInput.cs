using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterInput : MonoBehaviour
{

    [SerializeField] private float speed = 1;
    [SerializeField] private bool lookFront = true;
    private bool isAlive;
    private Animator animatorController;
    [SerializeField] private GameObject attackZone;
    [SerializeField] private float tiempoDeAtaque;
    private float attackTimer;
    [SerializeField] private AudioClip swordSound;
    static AudioSource audioSource;
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
    public void GetKilled()
    {
        isAlive = false;
        attackTimer = 0;
    }
    void Update()
    {
    if (isAlive)
    {
            float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.position += new Vector3(xMovement, 0f, 0f);
            bool keyRightDown = Input.GetKeyDown(KeyCode.A);
            bool keyLeftDown = Input.GetKeyDown(KeyCode.D);
            bool TriggerAttack = Input.GetKeyDown(KeyCode.C);
            bool KeyRightUp = Input.GetKeyUp(KeyCode.A);
            bool keyLeftUp = Input.GetKeyUp(KeyCode.D);
            if (keyRightDown && lookFront)
            {
               transform.Rotate(0,180,0);
               lookFront = false;
            }
    
            if (keyLeftDown && !lookFront)
            {
               transform.Rotate(0,180,0);
               lookFront = true;
            }
    
            if (keyLeftUp || KeyRightUp && !(keyLeftDown || keyRightDown))
            {
                animatorController.SetBool("IsRunning", false);
               // Debug.Log("Dejo de correr");
            }
    
            if (keyLeftDown || keyRightDown)
            {
                animatorController.SetBool("IsRunning", true);
            }
            if (TriggerAttack)
            {
                Attack();
            }

            if (attackZone.activeInHierarchy)
            {
                if (attackTimer >= tiempoDeAtaque)
                {
                    attackZone.SetActive(false);
                    attackTimer = 0;
                }
                else
                {
                    attackTimer += Time.deltaTime;
                }
            }
    }

    /*
    leftCondition = Input.GetKey(KeyCode.A);
    rightCondition = Input.GetKey(KeyCode.D);
    jumpCondition = Input.GetKey(KeyCode.Space);
    attackCondition = Input.GetKey(KeyCode.K);
    if (leftCondition)
    {
        /*float XAxis = 1 * -speed * Time.deltaTime;
        transform.Translate(new Vector3(XAxis, 0, 0)); 
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
    */
    }

    void Awake()
    {
        animatorController = GetComponent<Animator>();
        isAlive = true;
        attackZone.SetActive(false);
        attackTimer = 0;
        audioSource = GetComponent<AudioSource>();
        }
    private void Attack()
    {
        Debug.Log("Evento ataque");
        animatorController.SetTrigger("attackEvent");
        attackZone.SetActive(true); 
audioSource.PlayOneShot(swordSound);
    }
}
