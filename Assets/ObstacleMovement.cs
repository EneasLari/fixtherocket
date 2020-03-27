using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 endingPosition;
    public float Distance=40;
    private float currentDistance=0;
    public float Speed;
    float Timer;

    Vector3 pointA = Vector3.zero;
    Vector3 pointB = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = new Vector3(transform.position.x, transform.position.y-Distance, transform.position.z);
        pointB.y = Distance;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime * Speed;
        if (currentDistance < Distance) {
            transform.position = Vector3.Lerp(startingPosition, endingPosition, Timer);
            currentDistance = Vector3.Lerp(pointA, pointB, Timer).y;
        } else {
            currentDistance = 0;
            Timer = 0;
            endingPosition = startingPosition;
            startingPosition = transform.position;
            pointA = Vector3.zero;
            pointB = Vector3.zero;
            pointB.y = Distance;
        }
    }
}
