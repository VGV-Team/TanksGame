using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : UnitScript
{
    public GameObject Projectile;
    public GameObject ProjectileStartLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveForward()
    {
        Vector3 newPos = gameObject.transform.position + gameObject.transform.forward * 1 * Time.deltaTime;
        gameObject.transform.position = newPos;
    }

    public void MoveBackward()
    {
        Vector3 newPos = gameObject.transform.position + gameObject.transform.forward * -1 * Time.deltaTime;
        gameObject.transform.position = newPos;
    }

    public void TurnLeft()
    {
        gameObject.transform.Rotate(0, -50 * Time.deltaTime, 0);
    }

    public void TurnRight()
    {
        gameObject.transform.Rotate(0, 50 * Time.deltaTime, 0);
    }

    public void Shoot()
    {
        GameObject projectile = (GameObject)Instantiate(Projectile,
                ProjectileStartLocation.gameObject.transform.position,
                ProjectileStartLocation.gameObject.transform.rotation
            );

        projectile.GetComponent<ProjectileScript>().AliveTime = 2;
    }

    public override void Hit(int damage)
    {
        Health -= damage;
        if(Health <= 0)
            Die();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }
}
