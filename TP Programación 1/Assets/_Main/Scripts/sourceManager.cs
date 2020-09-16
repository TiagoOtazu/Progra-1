using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sourceManager : MonoBehaviour
{
    

    public static AudioClip ShootFlyEye;

    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        ShootFlyEye = Resources.Load<AudioClip>("ShootFlyEye");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "ShootFlyEye":
                audioSource.PlayOneShot(ShootFlyEye);
                break;
                    

        }
    
    } 
    
       
    
       
}
