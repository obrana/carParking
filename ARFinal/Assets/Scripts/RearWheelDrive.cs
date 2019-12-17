using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RearWheelDrive : MonoBehaviour
{
    public float maxAngle = 30;
    public float maxTorque = 300;
    public WheelCollider[] wheelColliderArray;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = maxAngle * CrossPlatformInputManager.GetAxis("Horizontal");
        float torque = maxTorque * CrossPlatformInputManager.GetAxis("Vertical");

        wheelColliderArray[0].steerAngle = angle;
        wheelColliderArray[1].steerAngle = angle;

        wheelColliderArray[2].motorTorque = torque;
        wheelColliderArray[3].motorTorque = torque;

        foreach(WheelCollider wheelCollider in wheelColliderArray)
        {
            Vector3 p;
            Quaternion q;

            wheelCollider.GetWorldPose(out p, out q);

            Transform wheelShape = wheelCollider.transform.GetChild(0);
            wheelShape.position = p;
            wheelShape.rotation = q;
        }
    }
}
