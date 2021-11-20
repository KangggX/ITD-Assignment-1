using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class InstrumentInteraction : MonoBehaviour
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

                if (inputNum == 0)
                {
                    _guitar.interactionCheckArray[inputNum] = true;
                }
                return;

            case (InstrumentPart.GuitarString):
                _guitar = GetComponentInParent<Guitar>();

                if (inputNum == 1)
                {
                    _guitar.interactionCheckArray[inputNum] = true;
                }
                return;
        }
    }

    public void Released(int inputNum)
    {
        switch (instrumentPart)
        {
            case (InstrumentPart.GuitarNeck):
                _guitar = GetComponentInParent<Guitar>();

                if (inputNum == 0)
                {
                    _guitar.interactionCheckArray[inputNum] = false;
                }
                return;

            case (InstrumentPart.GuitarString):
                _guitar = GetComponentInParent<Guitar>();

                if (inputNum == 1)
                {
                    _guitar.interactionCheckArray[inputNum] = false;
                }
                return;
        }
    }
}
