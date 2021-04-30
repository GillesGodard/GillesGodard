using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phisic_cube : MonoBehaviour
{
    Rigidbody rB;

    public float force;
    public float forceAuto;
    // Start is called before the first frame update
    void Start()
    {
       rB = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        rB.AddForce(Vector3.up*force,ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        rB.AddForce(Vector3.right* forceAuto, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
