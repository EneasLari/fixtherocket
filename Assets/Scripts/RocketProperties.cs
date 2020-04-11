using Assets.Scripts.UserSystem.GlobalData;
using PathCreation.PathFollower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketProperties : MonoBehaviour
{
    public int PointsToUnlock=20;
    public float Speed=10;
    public RocketPathFollower rocketPathFollower;
    // Start is called before the first frame update
    void Start()
    {
        rocketPathFollower.speed = Speed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
