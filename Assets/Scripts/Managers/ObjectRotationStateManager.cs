using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotationStateManager : MonoBehaviour
{
    [Header("Image Target Objects")]
    [SerializeField] private Transform targets;
    private List<GameObject> _itObjects = new List<GameObject>();

    [Header("Ground Plane Objects")]
    [SerializeField] private Transform planes;
    private List<GameObject> _gpObjects = new List<GameObject>();

    [Header("Mid Air Objects")]
    [SerializeField] private Transform stages;
    private List<GameObject> _maObjects = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < targets.childCount; i++)
        {

        }
    }

}
