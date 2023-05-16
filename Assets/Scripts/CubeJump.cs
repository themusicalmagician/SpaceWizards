using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJump : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        rb.AddForce(transform.forward * 5000);
        rb.useGravity = true;
    }

 

}
