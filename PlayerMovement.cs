using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce ;
    public float sidewaysForce;
    public bool isKeyDPressed = false;
    public bool isKeyAPressed = false;

    // Update is called once per frame
    void Update()
    {
        //adding forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //chech for button d
        if( Input.GetKeyDown("d"))
            isKeyDPressed = true;
        if( Input.GetKeyUp("d"))
            isKeyDPressed = false;

        //check for button a
        if( Input.GetKeyDown("a"))
            isKeyAPressed = true;
        if( Input.GetKeyUp("a"))
            isKeyAPressed = false;

        //create sideways movement
        if(isKeyDPressed)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
    
        if (isKeyAPressed)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if( rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
