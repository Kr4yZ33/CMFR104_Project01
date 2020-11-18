using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // Reference to our Audio Source
    public AudioClip trackConnectionClip; // reference to our track connected clip
    public AudioClip bgm; // reference to our game music
    AudioClip currentTrack; // the current track being played
    //AudioClip previousTrack; // the previous track that was played
    public float volume = 0.5f; // Reference to the volume of our scare shot clip (plays over game musice that is already playing)
    public float delay = 2;

    /// <summary>
    /// Play car skeleton exploding sound clip
    /// </summary>
    public void PlayTrackConnectionClip()
    {
        if (currentTrack == trackConnectionClip)
        {
            return;
        }
        currentTrack = trackConnectionClip;
        audioSource.PlayOneShot(trackConnectionClip, volume);
        Invoke("SoundClipOverlap()", delay);
        return;
    }

    public void SoundClipOverlap()
    {
        Debug.Log("delay triggered");
    }
}
