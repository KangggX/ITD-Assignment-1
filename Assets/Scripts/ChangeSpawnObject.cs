using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeSpawnObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> _stageList;
    [SerializeField] private Transform _stageTransform;
    [SerializeField] private ContentPositioningBehaviour _planeGameobject;
    [SerializeField] private GameObject _planeFinder;

    private int _currIndex = 0;

    private void Awake()
    {
        _planeGameobject.GetComponent<ContentPositioningBehaviour>();
    }

    private void Start()
    {
        int child = _stageTransform.childCount;

        for (int i = 0; i < child; i++)
        {
            _stageList.Add(_stageTransform.GetChild(i).gameObject);
        }
    }

    public void OnButtonPressed()
    {
        ChangeIndex();

        if (_planeFinder != null && !_planeFinder.activeSelf)
        {
            _planeFinder.SetActive(true);
        }
    } 

    private void ChangeIndex()
    {
        int objectAmount = _stageList.Count;

        if (_currIndex == objectAmount - 1)
        {
            _currIndex = 0; //To ensure the current index does not exceed the total index of the list
        }
        else
        {
            _currIndex++; //Increment current index by 1
        }

        for (int i = 0; i < objectAmount; i++)
        {
            if (i == _currIndex)
            {
                // Change the current anchor stage
                _planeGameobject.AnchorStage = _stageList[i].GetComponent<AnchorBehaviour>(); 
            }
        }
    }
}
