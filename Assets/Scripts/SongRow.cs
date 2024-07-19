using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SongRow : MonoBehaviour
{
    [SerializeField] GameObject text_obj;
    [SerializeField] GameObject parent;
    [SerializeField] GameObject star;
    [SerializeField] GameObject starCp;

    private Song song;

    public void setSong(Song song) {
        this.song = song;
        this.setText(song.name);
        this.setStar(song.star);
    }

    public void setText(string text) {
        TextMeshProUGUI score_text = text_obj.GetComponentInChildren<TextMeshProUGUI>();
        score_text.text = text;
    }

    public void setStar(int count) {
        string text = "";
        for (int i = 0; i < count; i++) {
            text += "*";
        }
        TextMeshProUGUI score_text = starCp.GetComponentInChildren<TextMeshProUGUI>();
        score_text.text = text;
        // Instantiate(star, parent.transform, false);
    }

    public void onClick() {
        Debug.Log(Singleton.instance);
        Singleton.instance.setSong(this.song);
        SceneManager.LoadScene("SongScene");
    }
}
