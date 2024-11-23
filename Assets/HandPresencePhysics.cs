using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPresencePhysics : MonoBehaviour
{

    public Transform target;
    private Rigidbody rb;
    public Renderer noPhysicalHand;
    public float showNonPhysicalHandDistance = 0.05f;

    public GameObject handPhysical;

    private Collider[] handColliders;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        handColliders = GetComponentsInChildren<CapsuleCollider>();


    }
      
    public void EnableHandCollider()
    {
        foreach (var item in handColliders)
        {
            item.enabled = true;
        }
        //handPhysical.SetActive(true);

        
    }

    public void EnableDelay(float delay)
    {
        Invoke("EnableHandCollider", delay);
    }

    public void DisableHandCollider()
    {
        // handPhysical.SetActive(false);
        foreach (var item in handColliders)
        {
            item.enabled = false;
        }

    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > showNonPhysicalHandDistance)
        {
            noPhysicalHand.enabled = true;
        } else
        {
            noPhysicalHand.enabled = false;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //position
        rb.velocity = (target.position - transform.position) /Time.fixedDeltaTime;

        //rotation
        Quaternion rotationDifference = target.rotation * Quaternion.Inverse(transform.rotation);
        rotationDifference.ToAngleAxis(out float angleInDegree, out Vector3 rotationAxis);

        Vector3 rotationDifferenceInDegree = angleInDegree * rotationAxis;

        rb.angularVelocity = (rotationDifferenceInDegree *Mathf.Deg2Rad / Time.fixedDeltaTime);
    }
}
