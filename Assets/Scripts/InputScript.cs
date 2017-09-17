using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public GameObject PlayerTank;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (PlayerTank == null)
	        return;

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
}
