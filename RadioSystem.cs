using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialHeliReply;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMakeCall()
    {
        print(name + "OnMakeCall");
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("InitialReply", initialHeliCall.length + 1f);
    }

    void InitialReply()
    {
        audioSource.clip = initialHeliReply;
        audioSource.Play();
        BroadcastMessage("HeliLeft");
    }

}
