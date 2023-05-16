using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 GrapplePoint;
    public LayerMask WhatisGrapple;
    public Transform gunTip;
    public Transform Camera;
    public Transform Player;
    public float maxDistance = 100f;
    private SpringJoint joint;


    private void Awake()
    {
        lr = GetComponent<LineRenderer>();

    }

    private void Update()
    {
        DrawRope();

        if (Input.GetButtonDown("Fire1"))
        {
            StartGrapple();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopGrapple();
        }

        void StartGrapple()
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.position, Camera.forward, out hit, maxDistance, WhatisGrapple))
            {
                GrapplePoint = hit.point;
                joint = Player.gameObject.AddComponent<SpringJoint>();
                joint.autoConfigureConnectedAnchor = false;
                joint.connectedAnchor = GrapplePoint;

                float distanceFromPoint = Vector3.Distance(Player.position, GrapplePoint);

                joint.maxDistance = distanceFromPoint * 0.8f;
                joint.minDistance = distanceFromPoint * 0.25f;

                joint.spring = 4.5f;
                joint.damper = 7f;
                joint.massScale = 4.5f;

            }
        }

        void DrawRope()
        {
            lr.SetPosition(0, gunTip.position);
            lr.SetPosition(1, GrapplePoint);
        }

        void StopGrapple()
        {

        }
    }
}
