using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Guitar Audio")]
    [SerializeField] private GameObject _guitarAudios;

    [Header("Drum Audio")]
    [SerializeField] private GameObject _drumAudios;

    [Header("Flute Audio")]
    [SerializeField] private GameObject _fluteAudios;

    [Header("Keyboard Audio")]
    [SerializeField] private GameObject _keyboardAudios;
    private List<AudioSource> _keyboardAudioList = new List<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        // Adding Keyboard audio sources into a list
        for (int i = 0; i < _keyboardAudios.GetComponents<AudioSource>().Length; i++)
        {
            _keyboardAudioList.Add(_keyboardAudios.GetComponents<AudioSource>()[i]);
        }
    }

    public void PlayKeyboardAudio()
    {
        int listCount = _keyboardAudioList.Count;
    }
}
