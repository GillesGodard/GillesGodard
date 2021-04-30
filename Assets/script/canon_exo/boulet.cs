using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulet : MonoBehaviour

{
    public GameObject prefab;
    float elapsedTime;
    public float waiting =0.1f ;

    GameObject instance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))

            elapsedTime += Time.deltaTime;


        if (elapsedTime > waiting)
        {
            instance = Instantiate(prefab, transform.position, transform.rotation);
            elapsedTime = 0.0f;
        }
        

    }
}