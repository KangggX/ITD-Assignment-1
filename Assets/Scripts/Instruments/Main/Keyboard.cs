using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : InstrumentHandler
{
    public static event Action<int> keyboardAudioEvent;

    protected override void Update()
    {
        base.Update();

        for (int i = 0; i < interactionCheckArray.Length; i++)
        {
            if (interactionCheckArray[i])
            {
                keyboardAudioEvent?.Invoke(i);
            }
        }
    }
}
