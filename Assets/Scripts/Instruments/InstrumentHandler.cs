using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstrumentHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _debugText;
    [SerializeField] private int _interactionCount;
    public bool[] interactionCheckArray;

    private void Awake()
    {
        interactionCheckArray = new bool[_interactionCount];
    }

    protected virtual void Update()
    {
        //if (interactionCheckArray[1])
        //{
        //    _debugText.text = "true";
        //}
        //else
        //{
        //    _debugText.text = "false";
        //}
    }
}
