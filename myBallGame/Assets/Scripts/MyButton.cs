using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour, IClickable
{
    public GameManager.PlanetType openPlanet;
    public void Click()
    {
        GameManager.currentPlanet = openPlanet;
        StartLevel();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Game");
    }
}
