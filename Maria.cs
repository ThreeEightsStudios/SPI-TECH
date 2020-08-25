using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;


public class StartTraining : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {
        actions.Add("This Is What You Want Her To Say", Private Void Name It What You Want);


        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {

        actions[speech.text].Invoke();
    }

    private void Name It What Its Called On Line 18()
    {
        // Scene Must Be Added To The Build Settings To Switch Scenes.
        SceneManager.LoadScene(Example_Scene);
    }
}

