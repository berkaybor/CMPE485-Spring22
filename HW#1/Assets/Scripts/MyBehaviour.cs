using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehaviour : MonoBehaviour
{
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(new Vector3(1, 0, 0));
    }
}
