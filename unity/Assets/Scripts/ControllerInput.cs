using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

/// <summary>
/// The inputchecker has to be on both the controller and needs the RigControl to work accordingly.
/// </summary>
public class ControllerInput : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;

    [SerializeField] private GameObject leftController = null;
    [SerializeField] private GameObject rightController = null;
    [SerializeField] private RigControl playerRig = null;

    [HideInInspector] private SteamVR_Input_Sources leftInput = SteamVR_Input_Sources.LeftHand;
    [HideInInspector] private SteamVR_Input_Sources rightInput = SteamVR_Input_Sources.RightHand;

    void Start()
    {
        //sets the trakcing object
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Update()
    {
        //checks which controllers is being used during the which sets the boolean on the respective controller to true or false when the trigger is used

        if (gameObject == leftController)
        {
            if (SteamVR_Actions._default.Squeeze.GetAxis(leftInput) == 1)
            {
                playerRig.isLeftGripped = true;
            }

            else
            {
                playerRig.isLeftGripped = false;
            }
        }

        else if (gameObject == rightController)
        {
            if (SteamVR_Actions._default.Squeeze.GetAxis(rightInput) == 1)
            {
                playerRig.isRightGripped = true;
            }
            
            else
            {
                playerRig.isRightGripped = false;
            }
        }
    }
}
