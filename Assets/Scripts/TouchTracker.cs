using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTracker : MonoBehaviour
{
    private Touch _firstTouch;
    private bool _canRotate = false;

    private void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        if (Input.GetMouseButtonDown(0) && !_canRotate)
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                InstrumentHandler instrumentPartHit = hit.collider.GetComponent<InstrumentHandler>();
                //Debug.Log(_astronautPlaneStage);

                if (instrumentPartHit != null)
                {
                    Debug.Log("First touch is at: " + Input.mousePosition);
                    Debug.Log(instrumentPartHit.instrumentPart);
                }
            }
            else
            {
                return;
            }

            //Debug.Log(Input.mousePosition);
        }
    }

    public bool ObjectRotation
    {
        get
        {
            return _canRotate;
        }

        set
        {
            _canRotate = !_canRotate;
        }
    } 
}
