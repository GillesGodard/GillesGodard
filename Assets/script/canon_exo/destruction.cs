using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{

    float traveled = 10.0f;
    public float speed = 5.0f;
    Vector3 origine;

    // Start is called before the first frame update
    void Start()
    {
        origine = transform.position;     
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;


        if (Vector3.Magnitude(transform.position - origine) > traveled)
        {
           Destroy( gameObject );
        }

        
    }
}
