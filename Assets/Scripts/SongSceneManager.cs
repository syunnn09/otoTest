using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SongSceneManager : MonoBehaviour
{
    [SerializeField] GameObject textObj;
    private Song song;

    void Start()
    {
        song = Singleton.instance.getSong();
        TextMeshProUGUI score_text = textObj.GetComponentInChildren<TextMeshProUGUI>();
        score_text.text = song.name;

        StartCoroutine(play());
    }

    IEnumerator play() {
        yield return new WaitForSeconds(2.0f);
        AudioSource audio = GetComponent<AudioSource>();
        audio.time = song.demostart;
        audio.Play();
    }
}
