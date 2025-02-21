using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private PlayerController controller;
    
    public void Initialize(PlayerController playerController)
    {
        controller = playerController;
    }
    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        controller?.Move(new Vector2(moveX, moveY), speed);
    }
}