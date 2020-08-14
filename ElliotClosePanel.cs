using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;


public class ElliotClosePanel : MonoBehaviour
{
    public GameObject Panel;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {
        actions.Add("Set This Text To What You Want", EImReady);


        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {

        actions[speech.text].Invoke();
    }

    private void EImReady()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}

