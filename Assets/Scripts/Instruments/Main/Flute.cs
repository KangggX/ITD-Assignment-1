using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute : InstrumentHandler
{
    public static event Action<InstrumentHandler> fluteAudioEvent; //Subscribed by AudioManager class

    protected override void Update()
    {
        base.Update();

        if (interactionCheckArray[0] && interactionCheckArray[1])
        {
            fluteAudioEvent?.Invoke(gameObject.GetComponent<InstrumentHandler>());
        }
    }
}
