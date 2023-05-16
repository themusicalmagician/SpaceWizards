using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float zMin;
    public float zMax;
    public Vector3 EnemyLocation;

    int speed;

    public bool moveRight;
    public bool moveLeft;

    void Start()
    {
        //give random speed
        speed = Random.Range(10, 36);

        //set random direction
        if(Random.value > 0.5f)
        {
            moveRight = true;
            moveLeft = false;
        }
        else
        {
            moveRight = false;
            moveLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }

        if (moveLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }

        if(transform.position.x < xMin)
        {
            moveLeft = false;
            moveRight = true;
        }

        if(transform.position.x > xMax)
        {
            moveLeft = true;
            moveRight = false;
        }

        if(transform.position.z < zMin)
        {
            moveLeft = true;
            moveRight = false;
        }

        if(transform.position.z > zMax)
        {
            moveLeft = false;
            moveRight = true;
        }
    }
}
