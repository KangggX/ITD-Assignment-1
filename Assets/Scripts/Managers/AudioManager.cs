using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    [Header("Guitar Audio")]
    [SerializeField] private GameObject _guitarAudios;
    private List<AudioSource> _guitarAudioList = new List<AudioSource>();

    [Header("Drum Audio")]
    [SerializeField] private GameObject _drumAudios;
    private List<AudioSource> _drumAudioList = new List<AudioSource>();

    [Header("Flute Audio")]
    [SerializeField] private GameObject _fluteAudios;
    private List<AudioSource> _fluteAudioList = new List<AudioSource>();

    [Header("Keyboard Audio")]
    [SerializeField] private GameObject _keyboardAudios;
    private List<AudioSource> _keyboardAudioList = new List<AudioSource>();

    private void OnEnable()
    {
        Guitar.guitarAudioEvent += PlayGuitarAudio;
        Drum.drumAudioEvent += PlayDrumAudio;
        Flute.fluteAudioEvent += PlayFluteAudio;
        Keyboard.keyboardAudioEvent += PlayKeyboardAudio;
    }

    private void OnDisable()
    {
        Guitar.guitarAudioEvent -= PlayGuitarAudio;
        Drum.drumAudioEvent -= PlayDrumAudio;
        Flute.fluteAudioEvent -= PlayFluteAudio;
        Keyboard.keyboardAudioEvent -= PlayKeyboardAudio;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Adding Guitar audio sources into a list (_guitarAudioList)
        for (int i = 0; i < _guitarAudios.GetComponents<AudioSource>().Length; i++)
        {
            _guitarAudioList.Add(_guitarAudios.GetComponents<AudioSource>()[i]);
        }

        // Adding Drum audio sources into a list (_drumAudioList)
        for (int i = 0; i < _drumAudios.GetComponents<AudioSource>().Length; i++)
        {
            _drumAudioList.Add(_drumAudios.GetComponents<AudioSource>()[i]);
        }

        // Adding Flute audio sources into a list (_fluteAudioList)
        for (int i = 0; i < _fluteAudios.GetComponents<AudioSource>().Length; i++)
        {
            _fluteAudioList.Add(_fluteAudios.GetComponents<AudioSource>()[i]);
        }

        // Adding Keyboard audio sources into a list (_keyboardAudioList)
        for (int i = 0; i < _keyboardAudios.GetComponents<AudioSource>().Length; i++)
        {
            _keyboardAudioList.Add(_keyboardAudios.GetComponents<AudioSource>()[i]);
        }
    }

    public void PlayGuitarAudio(InstrumentHandler iHandler)
    {
        int listCount = _guitarAudioList.Count;

        // Play a random audio from the AudioList
        _guitarAudioList[Random.Range(0, listCount - 1)].Play();

        // To ensure that music play once and player have to click the Guitar String again
        iHandler.interactionCheckArray[1] = false; 
    }

    public void PlayDrumAudio(InstrumentHandler iHandler)
    {
        // Play drum audio
        _drumAudioList[0].Play();

        // To ensure that music play once and player have to click the Drum again
        iHandler.interactionCheckArray[0] = false;
    }

    public void PlayFluteAudio(InstrumentHandler iHandler)
    {
        int listCount = _fluteAudioList.Count;

        // Play a random audio from the AudioList
        _fluteAudioList[Random.Range(0, listCount - 1)].Play();

        // To ensure that music play once and player have to click the Flute Key again
        iHandler.interactionCheckArray[1] = false;
    }

    public void PlayKeyboardAudio(int index, InstrumentHandler iHandler)
    {
        int listCount = _keyboardAudioList.Count;
        _keyboardAudioList[index].Play();
        iHandler.interactionCheckArray[index] = false;

        //_keyboardAudioList[Random.Range(0, listCount - 1)].Play();
    }
}
