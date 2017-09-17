using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public GameObject PlayerTank;
    public GameObject EnemyTank;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (PlayerTank != null)
	    {
            if (Input.GetKey(KeyCode.W))
            {
                PlayerTank.GetComponent<TankScript>().MoveForward();
            }
            if (Input.GetKey(KeyCode.A))
            {
                PlayerTank.GetComponent<TankScript>().TurnLeft();
            }
            if (Input.GetKey(KeyCode.S))
            {
                PlayerTank.GetComponent<TankScript>().MoveBackward();
            }
            if (Input.GetKey(KeyCode.D))
            {
                PlayerTank.GetComponent<TankScript>().TurnRight();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerTank.GetComponent<TankScript>().Shoot();
            }
        }

        if (EnemyTank != null)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                EnemyTank.GetComponent<TankScript>().MoveForward();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                EnemyTank.GetComponent<TankScript>().TurnLeft();
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                EnemyTank.GetComponent<TankScript>().MoveBackward();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                EnemyTank.GetComponent<TankScript>().TurnRight();
            }

            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                EnemyTank.GetComponent<TankScript>().Shoot();
            }
        }
    }
}
