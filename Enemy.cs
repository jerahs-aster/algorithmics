using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public Transform target;
    public int playerDamage = 2;

    // Update is called once per frame
    void Update()
    {
        //Changes the NPC position to a new one every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //Turns the NPC each frame to face the target
        transform.LookAt(target.position);
    }

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            player.TakeDamage(playerDamage);
        }
    }
}