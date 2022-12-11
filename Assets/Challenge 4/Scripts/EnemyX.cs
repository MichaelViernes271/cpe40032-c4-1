﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
	public float speed;
	// hint 5: added value
	// public float speed = 100.f;
    private Rigidbody enemyRb;
    private GameObject playerGoal;

    // Start is called before the first frame update
    void Start()
    {
		// hint 5: added player gameobject
		// playerGoal = GameObject.Find("Player Goal");
        enemyRb = GetComponent<Rigidbody>();
		
		// hint 7: the enemies never gets difficult
		// spawnManagerScripts = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
		
		// hint 7: the enemies never gets too difficult
		// enemyRb.AddForce(lookDirection * spawnManagerScripts.enemySpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
