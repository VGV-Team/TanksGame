using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitScript : MonoBehaviour
{
    public int MaxHealth;
    public int Health;

    public virtual void Hit(int damage)
    {
    }

    public virtual void Die()
    {
    }
}
