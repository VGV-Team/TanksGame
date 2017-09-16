using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
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
        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime);
    }

    public void MoveBackward()
    {
        gameObject.transform.Translate(gameObject.transform.forward * -1 * Time.deltaTime);
    }

    public void TurnLeft()
    {
        gameObject.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }

    public void TurnRight()
    {
        gameObject.transform.Rotate(0, 0, -50 * Time.deltaTime);
    }

    public void Shoot()
    {
        GameObject projectile = (GameObject)Instantiate(Projectile,
                ProjectileStartLocation.gameObject.transform.position,
                ProjectileStartLocation.gameObject.transform.rotation
            //gameObject.transform.Find("Body").Find("Turret").Find("Barrel").Find("BarrelEnd").position,
            //gameObject.transform.Find("Body").Find("Turret").Find("Barrel").Find("BarrelEnd").rotation
            );

        projectile.GetComponent<ProjectileScript>().AliveTime = 2;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
