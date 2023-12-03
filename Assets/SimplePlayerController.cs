using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour

{
    public Rigidbody rigidbody;
    public float jumpForce;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    rigidbody.AddForce(Vector3.forward * movementSpeed);

        //    rigidbody.AddForce(Vector3.forward * movementSpeed * Time.deltaTime);

        //    #region Explaining Time.deltaTime
        //    // TWO PLAYERS
        //    // One is on a super-fast computer running at 250fps
        //    // The other is on an old laptop running at 10fps

        //    // Starting with 1 velocity
        //    // Player one's Time.deltaTime is 1/250 = 0.004
        //    // Player two's Time.deltaTime is 1/10  = 0.1


        //    // Player one velocity 1.004
        //    // Player two velocity 1.1

        //    // frame 2

        //    // starting with 250, and 10

        //    // Player one moving at 62500 velocity
        //    // Player two moving at   100 velocity
        //    #endregion



        //}
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed * Time.deltaTime);

    }
}
