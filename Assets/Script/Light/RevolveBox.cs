using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveBox : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 lastPosition;
    private int currentFace = 0;
    public static int newFace;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lastPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(1))
        {
            Vector3 nowPosition = Input.mousePosition;
            Vector3 posDelta = lastPosition - nowPosition;
            lastPosition = nowPosition;
            Quaternion rot = Quaternion.Euler(0, posDelta.x * speed, 0);
            transform.rotation = rot * transform.rotation;
        }
        if (Input.GetMouseButtonUp(1))
        {
            Rot();
        }
    }
    string Rot()
    {
        float zRotation = transform.rotation.eulerAngles.y;
        newFace = Mathf.FloorToInt(zRotation / 45f);
        string CurrentFace;
        if (newFace != currentFace)
        {
            currentFace = newFace;
        }
        return CurrentFace = newFace.ToString();
    }

}
