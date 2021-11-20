using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : InstrumentHandler
{
    public static event Action GuitarAudioEvent; //Subscribed by AudioManager class

    private void Update()
    {
        base.Update();

        if (interactionCheckArray[0] && interactionCheckArray[1])
        {
            GuitarAudioEvent?.Invoke();
        }
    }
}
