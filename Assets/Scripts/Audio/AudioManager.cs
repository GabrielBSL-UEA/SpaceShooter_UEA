using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Audio[] audios;
    public static AudioManager Instance;

    private Audio m_CurrentMusic;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        foreach (var s in audios)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.audio;
            s.source.name = s.name;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(AudioList newAudio, bool isMusic = false)
    {
        string audioName = newAudio.ToString();
        var s = Array.Find(audios, audio => audio.name == audioName);

        if(s == null)
        {
            Debug.LogWarning("Music " + audioName + " not found!");
            return;
        }

        s.source.Stop();
        s.source.Play();

        if (isMusic)
        {
            if(m_CurrentMusic != null) m_CurrentMusic.source.Stop();
            m_CurrentMusic = s;
        }
    }

    public void StopMusic() => m_CurrentMusic.source.Stop();
    public void PauseMusic() => m_CurrentMusic.source.Pause();
    public void ResumeMusic() => m_CurrentMusic.source.Play();
}
