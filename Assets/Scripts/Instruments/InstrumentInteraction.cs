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
            // Guitar things
            case (InstrumentPart.GuitarNeck):
                _guitar = GetComponentInParent<Guitar>();

                if (inputNum == 0)
                {
                    _guitar.interactionCheckArray[0] = true;
                }
                return;

            case (InstrumentPart.GuitarString):
                _guitar = GetComponentInParent<Guitar>();

                if (inputNum == 1)
                {
                    _guitar.interactionCheckArray[1] = true;
                }
                return;

            // Keyboard things
            case (InstrumentPart.KeyboardKey1):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[0] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey2):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[1] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey3):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[2] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey4):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[3] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey5):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[4] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey6):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[5] = true;
                }
                return;

            case (InstrumentPart.KeyboardKey7):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[6] = true;
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
