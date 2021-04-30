using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject prefab;
    float elapsedTime;

    GameObject instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            instance = Instantiate(prefab, transform.position, transform.rotation);

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 5.0f)
        {
            Destroy(instance);
            elapsedTime = 0.0f;
        }

    }
}
