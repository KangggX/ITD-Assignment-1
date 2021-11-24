using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstrumentHandler : MonoBehaviour
{
    [SerializeField] private int _interactionCount;
    public bool[] interactionCheckArray;

    // Initialize interactionCheckArray length with _interactionCount integer value
    private void Awake()
    {
        interactionCheckArray = new bool[_interactionCount];
    }

    protected virtual void Update()
    {
        Debug.Log("test");
    }
}
