using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int health;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
        attackPoint.
        position, attackPoint.
        rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }
}