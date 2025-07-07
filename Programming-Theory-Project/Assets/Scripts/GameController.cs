using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Player player = gameObject.AddComponent<Player>();
        player.Name = "Santiago";
        player.Health = 80;

        Enemy enemy = gameObject.AddComponent<Enemy>();
        enemy.Name = "Orco";
        enemy.Health = 60;

        player.Attack();
        enemy.Attack();
    }
}
