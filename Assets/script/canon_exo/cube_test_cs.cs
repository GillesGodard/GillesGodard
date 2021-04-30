using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_test_cs : MonoBehaviour
{
    public float speed = 0.1f;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update!");
        bool input = Input.GetKeyDown(KeyCode.Space);
        float rotation;

       // int scor


        if (input)
        {
            print("Space Down!");
        }
        if (Input.GetKeyUp(KeyCode.Space))
            print("Space Up!");

        if (Input.GetKey(KeyCode.Space)) print("Space!");


        if (Input.GetMouseButton(0)) print("Mouse!");

        if (Input.GetButton("Fire1")) print("Fire!");

        float directionH = Input.GetAxis("Horizontal"); // Q Dd

        float directionV = Input.GetAxis("Vertical");

        //print(directionH);
      //  print(directionV);

        if (Input.GetKeyDown(KeyCode.A))
            transform.position = new Vector3(10.0f, 0.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.E))
            transform.position += new Vector3(-1.0f, 0.0f, 0.0f);

        transform.position += Vector3.right * directionH * speed * Time.deltaTime;

        transform.position += Vector3.forward * directionV * speed * Time.deltaTime;

        Vector3 myRotation = transform.rotation.eulerAngles;

        //transform.localScale;

        float objDirection = 0;

        

        if (directionH > 0)
        {

            objDirection = 0;
            //print("1");
        }

        if (directionH < 0)
        {
            objDirection = 180;
            //print("2");
        }

        if (directionV > 0)
        {
            objDirection = -90;
            //print("3");
        }

        if (directionV < 0)
        {
            objDirection = 90;
          // print("4");
        }

        transform.rotation = Quaternion.AngleAxis(objDirection, Vector3.up);

    }

    private void OnTriggerEnter(Collider other)
    {

        score++;
        print(score);

    }
}