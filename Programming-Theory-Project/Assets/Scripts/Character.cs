using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string characterName;
    private int health;

    public string Name
    {
        get { return characterName; }
        set { characterName = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    public abstract void Attack();
}
