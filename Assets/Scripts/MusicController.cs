using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public List<AudioClip> tracks;
    public AudioSource audioSource;
    private int currentTrackIndex = 0;

    public GameObject pauseMenu;

    private void Start()
    {
        PlayNextTrack();
    }

    private void PlayNextTrack()
    {
        if (tracks.Count == 0)
        {
            Debug.LogWarning("No tracks assigned to the MusicPlayer.");
            return;
        }

        audioSource.Stop();
        audioSource.clip = tracks[currentTrackIndex];
        audioSource.Play();

        currentTrackIndex = (currentTrackIndex + 1) % tracks.Count;
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextTrack();
        }
    }
}
