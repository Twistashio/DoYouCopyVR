using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{

    public GameObject rightTeleportation;


    public InputActionProperty rightActivate;
    public InputActionProperty rightGrab;
    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float grabValue = rightGrab.action.ReadValue<float>();

        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);

        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);


        if (grabValue == 0)
        {
            rightTeleportation.SetActive(!isRightRayHovering && !isLeftRayHovering && rightActivate.action.ReadValue<float>() > 0.1f);
        }
    }
}
