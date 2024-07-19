using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class SongsController : MonoBehaviour
{
    [SerializeField] GameObject songRow;

    void Start()
    {
        Songs songs = getSongs();
        foreach (Song song in songs.songs) {
            GameObject row = Instantiate(songRow, this.transform);
            SongRow row_text = row.GetComponent<SongRow>();
            row_text.setSong(song);
        }
    }

    Songs getSongs()
    {
        string guitxt = "";
        FileInfo fi = new FileInfo(Application.dataPath + "/" + "scripts/songs.json");
        using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
            guitxt = sr.ReadToEnd();
        }
        Debug.Log(guitxt);
        Songs song = JsonUtility.FromJson<Songs>(guitxt);
        return song;
    }
}
