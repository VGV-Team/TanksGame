using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureScript : UnitScript
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Hit(int damage)
    {
        Health -= damage;
        if (Health <= 0)
            Die();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }
}
