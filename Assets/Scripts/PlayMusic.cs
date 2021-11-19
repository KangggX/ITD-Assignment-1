using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{

    public AudioSource key1;
    public AudioSource key2;

    private void Update()
    {
        TrackCollider();
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

                else
                {
                    print("nothing");
                }
            }
        }
    }
}
