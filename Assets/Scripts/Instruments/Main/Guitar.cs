using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : InstrumentHandler
{
    public static event Action guitarAudioEvent; //Subscribed by AudioManager class

    protected override void Update()
    {
        base.Update();

        if (interactionCheckArray[0] && interactionCheckArray[1])
        {
            guitarAudioEvent?.Invoke();
        }
    }
}
