using UnityEngine;

[System.Serializable]
public class Audio
{
    [HideInInspector] public AudioSource source;

    public string name;
    public AudioClip audio;
    public float volume;
    public float pitch;
    public bool loop;
}
