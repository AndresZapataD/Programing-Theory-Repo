using UnityEngine;

public class Enemy : Character
{
    public override void Attack()
    {
        Debug.Log(Name + " lanza un hechizo oscuro.");
    }
}
