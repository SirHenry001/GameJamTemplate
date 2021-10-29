using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallScript : MonoBehaviour
{

    public Rigidbody myRB;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        //myRB.AddForce(Vector3.forward*speed); (VAIHTOEHTOINEN KOODI)
        myRB.AddForce(new Vector3(hor * speed,0, ver * speed));
    }
}
