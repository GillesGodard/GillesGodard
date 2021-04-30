using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    CharacterController controller;
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float directionH = Input.GetAxis("Horizontal"); // Q Dd

        float directionV = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.A))
            transform.position = new Vector3(10.0f, 0.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.E))
            transform.position += new Vector3(-1.0f, 0.0f, 0.0f);



        controller.Move(Vector3.right * directionH * speed * Time.deltaTime);

        controller.Move(Vector3.forward * directionV * speed * Time.deltaTime);

        controller.Move(Vector3.down*9.81f* Time.deltaTime);

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
        
        //controller.Move(Vector3.right * Time.deltaTime);

        
    }
}