using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTracker : MonoBehaviour
{
    private Touch _firstTouch;

    private void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log("First touch is at: " + Input.mousePosition);
                //Debug.Log(_astronautPlaneStage);
            }
            else
            {
                return;
            }

            Debug.Log("hi");
        }
    }
}
