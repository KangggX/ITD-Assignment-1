using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class InstrumentHandler : MonoBehaviour
{
    public InstrumentPart instrumentPart;

    private Guitar _guitar;
    private Drum _drum;
    private Flute _flute;
    private Keyboard _keyboard;

    public void Interacted(int inputNum)
    {
        switch (instrumentPart)
        {
            case (InstrumentPart.GuitarNeck):
                _guitar = GetComponentInParent<Guitar>();
                return;

            case (InstrumentPart.GuitarString):
                _guitar = GetComponentInParent<Guitar>();
                return;
        }
    }
}
