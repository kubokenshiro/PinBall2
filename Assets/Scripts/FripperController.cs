using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;
    private float flickAngle = -20;

    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(defaultAngle);
    }

    void Update()
    {
        //発展課題
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(flickAngle);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(flickAngle);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" && tag == "LeftFripperTag")
        {
            SetAngle(flickAngle);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(defaultAngle);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(defaultAngle);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" && tag == "LeftFripperTag")
        {
            SetAngle(defaultAngle);
        }
    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle; 
        this.myHingeJoint.spring = jointSpr;
    }

}
