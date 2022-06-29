using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTaleb : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = -15f;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
}
