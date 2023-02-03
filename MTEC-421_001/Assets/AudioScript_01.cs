using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class AudioScript_01 : MonoBehaviour
{


    [SerializeField] AudioClip[] BlankSounds;
    [SerializeField] float minAmp, maxAmp, minPtch, maxPtch, minCutOff, maxCutOff;
    AudioSource AUS_01;
    AudioLowPassFilter LPF;
    [SerializeField] KeyCode Space;

   
    void Start()
    {
        AUS_01 = GetComponent<AudioSource>(); // caching
        LPF = GetComponent<AudioLowPassFilter>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(Space))
        {
            if (AUS_01.isPlaying)
                AUS_01.Stop();
            AudioProcess();
        }      
    }

    void AudioProcess()
    {
        AUS_01.clip = BlankSounds[Random.Range(0, BlankSounds.Length)] ;
        AUS_01.pitch = Random.Range(minPtch, maxPtch);
        AUS_01.volume = Random.Range(minAmp, maxAmp);
        LPF.cutoffFrequency = Random.Range(minCutOff, maxCutOff);
        SliderControl.Instance.SetLPF(LPF.cutoffFrequency);
        SliderControl.Instance.SetVolume(AUS_01.volume);
        AUS_01.Play();
    }
}
