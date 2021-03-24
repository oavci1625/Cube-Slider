using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMovement;
    // Update is called once per frame
    void OnCollisionEnter( Collision collisionInfo)
    {
        if( collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.isKeyAPressed = false;
            playerMovement.isKeyDPressed = false;
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
