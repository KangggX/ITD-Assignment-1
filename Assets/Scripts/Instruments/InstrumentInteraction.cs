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
            // Guitar Enum
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

            // Drum Enum
            case (InstrumentPart.DrumHead):
                _drum = GetComponentInParent<Drum>();

                if (inputNum == 0)
                {
                    _drum.interactionCheckArray[0] = true;
                }
                return;

            // Flute Enum
            case (InstrumentPart.FluteHole):
                _flute = GetComponentInParent<Flute>();

                if (inputNum == 0)
                {
                    _flute.interactionCheckArray[0] = true;
                }
                return;

            case (InstrumentPart.FluteKey):
                _flute = GetComponentInParent<Flute>();

                if (inputNum == 1)
                {
                    _flute.interactionCheckArray[1] = true;
                }
                return;

            // Keyboard Enum
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

            // Guitar Enum
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

            // Drum Enum
            case (InstrumentPart.DrumHead):
                _drum = GetComponentInParent<Drum>();

                if (inputNum == 0)
                {
                    _drum.interactionCheckArray[0] = false;
                }
                return;

            // Flute Enum
            case (InstrumentPart.FluteHole):
                _flute = GetComponentInParent<Flute>();

                if (inputNum == 0)
                {
                    _flute.interactionCheckArray[0] = false;
                }
                return;

            case (InstrumentPart.FluteKey):
                _flute = GetComponentInParent<Flute>();

                if (inputNum == 1)
                {
                    _flute.interactionCheckArray[1] = false;
                }
                return;

            // Keyboard Enum
            case (InstrumentPart.KeyboardKey1):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[0] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey2):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[1] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey3):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[2] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey4):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[3] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey5):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[4] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey6):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[5] = false;
                }
                return;

            case (InstrumentPart.KeyboardKey7):
                _keyboard = GetComponentInParent<Keyboard>();

                if (inputNum == 0)
                {
                    _keyboard.interactionCheckArray[6] = false;
                }
                return;
        }
    }
}
