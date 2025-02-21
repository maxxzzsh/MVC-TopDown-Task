using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel model;
    private PlayerView view;
    private bool isMovable = true;

    public void Initialize(PlayerModel playerModel, PlayerView playerView)
    {
        model = playerModel;
        view = playerView;
        
        model.OnHealthChange += view.UpdateHealth;
        model.OnPlayerDeath += () => {isMovable = false;};
        model.OnPlayerDeath += view.OnDeath;
    }
    
    public void TakeDamage(int damage)
    {
        model.ChangeHealth(-damage);
    }

    public void Move(Vector2 direction, float speed)
    {
        if(isMovable)
            transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
}