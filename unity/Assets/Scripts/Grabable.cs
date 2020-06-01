using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabable : MonoBehaviour
{
    public Vector3 m_offset=Vector3.zero;
    public Vector3 m_offsetBody = Vector3.zero;
    private GameObject LaunchPt;
    private GameObject mainCamera;

    [HideInInspector]
    public ControllerInput m_Activated = null;

    private void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        LaunchPt = GameObject.FindGameObjectWithTag("BMLaunchPoint");
    }

   

    public virtual void action()
    {
        LaunchPt.GetComponent<LaunchBM>().ButtonLaunch();
    }

    public void applyoffset(Transform hand)
    {
        transform.SetParent(hand);
        transform.localRotation = Quaternion.identity;
        transform.localPosition = m_offset;
        transform.SetParent(null);
    }
}
