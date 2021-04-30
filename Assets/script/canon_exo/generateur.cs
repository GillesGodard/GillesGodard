using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateur : MonoBehaviour
{
    public GameObject prefab;
    float elapsedTime;
    GameObject instance;
    public float waiting = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > waiting)
        {
            instance = Instantiate(prefab, transform.position, transform.rotation);
            elapsedTime = 0.0f;
        }
    }
}
