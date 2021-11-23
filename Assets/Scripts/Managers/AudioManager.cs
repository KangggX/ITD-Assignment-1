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
        Keyboard.keyboardAudioEvent += PlayKeyboardAudio;
    }

    private void OnDisable()
    {
        Guitar.guitarAudioEvent -= PlayGuitarAudio;
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

    public void PlayDrumAudio()
    {

    }
    public void PlayFluteAudio()
    {

    }

    public void PlayKeyboardAudio(int index, InstrumentHandler iHandler)
    {
        int listCount = _keyboardAudioList.Count;
        _keyboardAudioList[index].Play();
        iHandler.interactionCheckArray[index] = false;

        //_keyboardAudioList[Random.Range(0, listCount - 1)].Play();
    }
}
