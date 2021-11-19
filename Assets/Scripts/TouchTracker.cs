using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchTracker : MonoBehaviour
{
    private Touch _firstTouch;
    private bool _canRotate = false;

    [SerializeField] private TextMeshProUGUI _debugText;
    [SerializeField] private TextMeshProUGUI _debugText2;

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
                    _debugText.text = instrumentPartHit.instrumentPart.ToString();
                }
            }
            else
            {
                return;
            }

            //Debug.Log(Input.mousePosition);
        }

        if (Input.touchCount > 0 && !_canRotate)
        {
            _firstTouch = Input.GetTouch(0);
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(_firstTouch.position), out hit))
            {
                InstrumentHandler instrumentPartHit = hit.collider.GetComponent<InstrumentHandler>();
                //Debug.Log(_astronautPlaneStage);

                if (instrumentPartHit != null)
                {
                    //Debug.Log("First touch is at: " + Input.mousePosition);
                    //Debug.Log(instrumentPartHit.instrumentPart);
                    _debugText.text = instrumentPartHit.instrumentPart.ToString();
                    _debugText2.text = Input.touchCount.ToString();
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
