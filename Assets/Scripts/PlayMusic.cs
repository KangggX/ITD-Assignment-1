using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{

    public AudioSource key1;
    public AudioSource key2;
    public AudioSource key3;
    public AudioSource key4;
    public AudioSource key5;
    public AudioSource key6;
    public AudioSource key7;

    public Slider slider;

    AudioSource m_MyAudioSource;

    private void Start()
    {
        slider.value = 1;
        m_MyAudioSource = GetComponent<AudioSource>();
    }



    private void Update()
    {
        TrackCollider();
        m_MyAudioSource.volume = slider.value;
    }

    //identify collider and play tune
    private void TrackCollider()
    {
        //activate function
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click detected");
            //raycasting
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //get info
            if (Physics.Raycast(ray, out hit))
            {
                //identify collider
                if (hit.collider.tag == "key1")
                {
                    print("key1");
                    //play music
                    key1.Play();
                }
                if (hit.collider.tag == "key2")
                {
                    print("key1");
                    //play music
                    key2.Play();
                }
                if (hit.collider.tag == "key3")
                {
                    print("key1");
                    //play music
                    key3.Play();
                }
                if (hit.collider.tag == "key4")
                {
                    print("key1");
                    //play music
                    key4.Play();
                }
                if (hit.collider.tag == "key5")
                {
                    print("key1");
                    //play music
                    key5.Play();
                }
                if (hit.collider.tag == "key6")
                {
                    print("key1");
                    //play music
                    key6.Play();
                }
                if (hit.collider.tag == "key7")
                {
                    print("key1");
                    //play music
                    key7.Play();
                }

                else
                {
                    print("nothing");
                }
            }
        }
    }
}
