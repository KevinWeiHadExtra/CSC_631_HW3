using UnityEngine;

public class PlayerCollistion : MonoBehaviour
{
   
   public PlayerMove movement;
   
    void OnCollistionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
