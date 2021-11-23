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

    private GameObject currInstrumentPart;

    private void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        //if (Input.GetMouseButton(0) && !_canRotate)
        //{
        //    RaycastHit hit;

        //    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        //    {
        //        Debug.Log(hit.collider.name);
        //    }

        //    //Debug.Log(Input.mousePosition);
        //}

        if (Input.touchCount > 0 && !_canRotate)
        {
            _firstTouch = Input.GetTouch(0);
            RaycastHit hit;

            switch (_firstTouch.phase)
            {
                case (TouchPhase.Began):
                    if (Physics.Raycast(Camera.main.ScreenPointToRay(_firstTouch.position), out hit))
                    {
                        InstrumentInteraction partHit = hit.collider.GetComponent<InstrumentInteraction>();
                        //Debug.Log(_astronautPlaneStage);

                        if (partHit != null)
                        {
                            //Debug.Log("First touch is at: " + Input.mousePosition);
                            //Debug.Log(instrumentPartHit.instrumentPart);
                            currInstrumentPart = partHit.gameObject;
                            _debugText.text = partHit.instrumentPart.ToString();
                            _debugText2.text = "started";
                            partHit.Interacted(0);
                        }
                        else if (partHit == null)
                        {
                            _debugText.text = "error";
                        }
                    }
                    else
                    {
                        break;
                    }
                    break;

                case (TouchPhase.Ended):
                    currInstrumentPart.GetComponent<InstrumentInteraction>().Released(0);
                    _debugText2.text = "ended";
                    break;
            }

            _secondTouch = Input.GetTouch(1);
            RaycastHit hit2;

            switch (_secondTouch.phase)
                {
                    case (TouchPhase.Began):
                        if (Physics.Raycast(Camera.main.ScreenPointToRay(_secondTouch.position), out hit2))
                        {
                            InstrumentInteraction partHit = hit2.collider.GetComponent<InstrumentInteraction>();
                            //Debug.Log(_astronautPlaneStage);

                            if (partHit != null)
                            {
                                currInstrumentPart = partHit.gameObject;
                                _debugText.text = partHit.instrumentPart.ToString();
                                _debugText2.text = "started";
                                partHit.Interacted(1);
                            }
                        }
                        else
                        {
                            return;
                        }

                        break;

                    case (TouchPhase.Ended):
                        currInstrumentPart.GetComponent<InstrumentInteraction>().Released(1);
                        _debugText2.text = "ended";
                        break;
                }
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
