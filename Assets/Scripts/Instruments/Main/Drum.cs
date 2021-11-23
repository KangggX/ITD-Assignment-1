using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drum : InstrumentHandler
{
    public static event Action<InstrumentHandler> drumAudioEvent; //Subscribed by AudioManager class

    protected override void Update()
    {
        base.Update();

        if (interactionCheckArray[0])
        {
            drumAudioEvent?.Invoke(gameObject.GetComponent<InstrumentHandler>());
        }
    }
}
