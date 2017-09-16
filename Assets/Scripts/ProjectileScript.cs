using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    public float AliveTime;

    public ProjectileScript(Vector3 position, Quaternion rotation)
    {
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
    }

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {

        if (AliveTime <= 0)
        {
            Destroy(gameObject);
        }
        gameObject.transform.Translate(gameObject.transform.forward * 10 * Time.deltaTime);
	    AliveTime -= Time.deltaTime;
	    
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Ignore
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            collision.gameObject.GetComponent<TankScript>().Die();
        }
        else
        {
            Destroy(gameObject);
        }

        
    }
}
