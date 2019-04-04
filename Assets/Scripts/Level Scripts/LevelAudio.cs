using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAudio : MonoBehaviour
{
    float masterV = 0f;

    public AudioSource audio;

    public AudioClip levelMusic;

    // Start is called before the first frame update
    void Start()
    {
        audio.loop = true;

        audio.clip = levelMusic;

        Debug.Log("Volume: " + PlayerPrefs.GetFloat("Master Volume"));

        masterV = PlayerPrefs.GetFloat("Master Volume");

        audio.volume = masterV * .8f;

        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //masterV = PlayerPrefs.GetFloat("Master Volume");
        audio.volume = masterV * .8f;
    }
}
