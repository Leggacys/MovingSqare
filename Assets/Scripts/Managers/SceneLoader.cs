using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public RectTransform blackCircle;

    private void Start()
    {
        LeanTween.value(30, 0, 2f).setOnUpdate(value =>
        {
            blackCircle.localScale = Vector3.one * value;
        }).setEaseInQuad();
    }

    public  void LoadGameRoom()
    {
        LeanTween.value(0, 30, 2.5f).setOnUpdate(value =>
        {
            blackCircle.localScale = Vector3.one * value;
        }).setEaseInCubic().setOnComplete(() => SceneManager.LoadScene(1));

    }

    public  void LoadMainMenu()
    {
        LeanTween.value(0, 30, 2.5f).setOnUpdate(value =>
        {
            blackCircle.localScale = Vector3.one * value;
        }).setEaseInCubic().setOnComplete(() =>SceneManager.LoadScene(0));
        
    }
}
