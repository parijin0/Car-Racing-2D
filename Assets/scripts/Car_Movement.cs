using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Car_Movement : MonoBehaviour

{

    public Transform transform;

    public float speed = 5f;

    // Start is called before the first frame update

    void Start()

    {

        transform = GetComponent<Transform>();

    }



    // Update is called once per frame

    void Update()

    {

        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);



        if(transform.position.y <= -10)

        {

            Destroy(gameObject);

        }

    }

}