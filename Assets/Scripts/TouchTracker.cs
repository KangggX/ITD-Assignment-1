using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchTracker : MonoBehaviour
{
    private Touch _firstTouch;
    private Touch _secondTouch;
    private bool _canRotate = false;

    [SerializeField] private TextMeshProUGUI _debugText;
    [SerializeField] private TextMeshProUGUI _debugText2;

    private void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        //if (Input.GetMouseButtonDown(0) && !_canRotate)
        //{
        //    RaycastHit hit;

        //    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        //    {
        //        InstrumentHandler instrumentPartHit = hit.collider.GetComponent<InstrumentHandler>();
        //        //Debug.Log(_astronautPlaneStage);

        //        if (instrumentPartHit != null)
        //        {
        //            Debug.Log("First touch is at: " + Input.mousePosition);
        //            Debug.Log(instrumentPartHit.instrumentPart);
        //            _debugText.text = instrumentPartHit.instrumentPart.ToString();
        //        }
        //    }
        //    else
        //    {
        //        return;
        //    }

        //    //Debug.Log(Input.mousePosition);
        //}

        if (Input.touchCount > 0 && !_canRotate)
        {
            _firstTouch = Input.GetTouch(0);

            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(_firstTouch.position), out hit))
            {
                InstrumentHandler partHit = hit.collider.GetComponent<InstrumentHandler>();
                //Debug.Log(_astronautPlaneStage);

                if (partHit != null)
                {
                    //Debug.Log("First touch is at: " + Input.mousePosition);
                    //Debug.Log(instrumentPartHit.instrumentPart);
                    _debugText.text = partHit.instrumentPart.ToString();
                    _debugText2.text = Input.touchCount.ToString();
                    partHit.Interacted(0);
                }
                else if (partHit == null) 
                {
                    _debugText.text = "error";
                }
            }
            else
            {
                return;
            }

            if (Input.touchCount == 2)
            {
                _secondTouch = Input.GetTouch(1);
                RaycastHit hit2;

                if (Physics.Raycast(Camera.main.ScreenPointToRay(_secondTouch.position), out hit2))
                {
                    InstrumentHandler partHit = hit.collider.GetComponent<InstrumentHandler>();
                    //Debug.Log(_astronautPlaneStage);

                    if (partHit != null)
                    {
                        partHit.Interacted(1);
                    }
                }
                else
                {
                    return;
                }
            }

            //if (Physics.Raycast(Camera.main.ScreenPointToRay(_secondTouch.position), out hit))
            //{
            //    InstrumentHandler partHit = hit.collider.GetComponent<InstrumentHandler>();
            //    //Debug.Log(_astronautPlaneStage);

            //    if (partHit != null)
            //    {
            //    }
            //}
            //else
            //{
            //    return;
            //}
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
