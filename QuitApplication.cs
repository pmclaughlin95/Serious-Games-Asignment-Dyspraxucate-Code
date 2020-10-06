﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    private Button quitButton;
    void Start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(ExitGame);
    }

    public void ExitGame()
    {
            Application.Quit();
        
    }
}