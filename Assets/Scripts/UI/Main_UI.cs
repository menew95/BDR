﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_UI : MonoBehaviour
{
    public RectTransform BG;

    void OnEnable()
    {

    }

    void OnDisable()
    {

    }

    public void OnClickStartBtn()
    {
        UIManager.Instance.CallMainUI();

        GameManager.Instance.audioManager.CallAudioClip(1);
    }

    public void OnClickExitBtn()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
