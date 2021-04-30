using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieceColect : MonoBehaviour
{

    Rigidbody rB;
    float elapsedTime;
    public float waiting = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > waiting)
        {
            Destroy(gameObject);
            elapsedTime = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
            Destroy(gameObject);
            print("ting");

    }
}
