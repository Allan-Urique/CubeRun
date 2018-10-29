using UnityEngine;

public class PlayerControll : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float horizontalForce = 100f;
    public float verticalForce = 30f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") ) {

            //Add a force to the right
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //Add a force to the left
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

       if (Input.GetKey("w"))
        {
            //Add a upwards force
            rb.AddForce(0, verticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            //Add downwards force
            rb.AddForce(0, -verticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < -1.5) {

            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
