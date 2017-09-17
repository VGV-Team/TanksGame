using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject PlayerHealthBar;
    public GameObject EnemyHealthBar;

    public GameObject PlayerTank;
    public GameObject EnemyTank;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	    PlayerHealthBar.GetComponent<Image>().fillAmount = (float)PlayerTank.GetComponent<UnitScript>().Health / PlayerTank.GetComponent<UnitScript>().MaxHealth;
        PlayerHealthBar.GetComponentInChildren<Text>().text = PlayerTank.GetComponent<UnitScript>().Health + " / " + PlayerTank.GetComponent<UnitScript>().MaxHealth;


        EnemyHealthBar.GetComponent<Image>().fillAmount = (float)EnemyTank.GetComponent<UnitScript>().Health / EnemyTank.GetComponent<UnitScript>().MaxHealth;
        EnemyHealthBar.GetComponentInChildren<Text>().text = EnemyTank.GetComponent<UnitScript>().Health + " / " + EnemyTank.GetComponent<UnitScript>().MaxHealth;
    }
}
