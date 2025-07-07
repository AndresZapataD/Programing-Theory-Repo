using UnityEngine;

public class Player : Character
{
    public override void Attack()
    {
        Debug.Log(Name + " ataca con una espada.");
    }
}
