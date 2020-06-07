using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telaport : MonoBehaviour
{
    public GameObject position1 = null;
    public GameObject position2 = null;
    public GameObject position3 = null;
    public GameObject position4 = null;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
            transform.position = position1.transform.position;

        if (OVRInput.GetDown(OVRInput.RawButton.B))
            transform.position = position2.transform.position;

        if (OVRInput.GetDown(OVRInput.RawButton.X))
            transform.position = position3.transform.position;

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
            transform.position = position4.transform.position;
    }
}
