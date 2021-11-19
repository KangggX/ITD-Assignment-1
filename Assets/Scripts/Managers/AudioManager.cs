using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Guitar Audio")]
    [SerializeField] private GameObject _guitarAudios;
    private AudioSource _guitar1;

    [Header("Drum Audio")]
    [SerializeField] private GameObject _drumAudios;
    private AudioSource _drum1;

    [Header("Flute Audio")]
    [SerializeField] private GameObject _fluteAudios;
    private AudioSource _flute1;

    [Header("Keyboard Audio")]
    [SerializeField] private GameObject _keyboardAudios;
    private List<AudioSource> _keyboardAudioList = new List<AudioSource>();
    private AudioSource _key1;
    private AudioSource _key2;
    private AudioSource _key3;
    private AudioSource _key4;
    private AudioSource _key5;
    private AudioSource _key6;
    private AudioSource _key7;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _keyboardAudios.GetComponents<AudioSource>().Length; i++)
        {
            _keyboardAudioList.Add(_keyboardAudios.GetComponents<AudioSource>()[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
