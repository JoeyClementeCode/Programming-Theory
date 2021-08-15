using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject[] dogs;
    public GameObject selectedDog;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PickLab()
    {
        selectedDog = dogs[2];
    }
    public void PickBeagle()
    {
        selectedDog = dogs[0];
    }

    public void PickBorder()
    {
        selectedDog = dogs[1];
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
