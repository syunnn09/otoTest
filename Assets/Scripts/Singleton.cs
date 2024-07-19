using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;
    private Song song;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void setSong(Song song)
    {
        this.song = song;
        Debug.Log(song);
    }

    public Song getSong()
    {
        return this.song;
    }
}