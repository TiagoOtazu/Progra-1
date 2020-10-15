using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FlyingEyeShootIA: MonoBehaviour
{
    public GameObject bullet;
    private float timeBetweenShoots;
    public float startTime;
    private Transform player;
    [SerializeField] private Transform firepoint;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (timeBetweenShoots <= 0)
        {
            Instantiate(bullet, firepoint.position, Quaternion.identity);
            sourceManager.PlaySound("ShootFlyEye");
            timeBetweenShoots = startTime;
        }
        else
        {
            timeBetweenShoots -= Time.deltaTime;
        }
    }
}
