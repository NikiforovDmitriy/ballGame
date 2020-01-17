using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartEarth() {
        GameManager.currentPlanet = GameManager.PlanetType.earth;
        StartLevel();
    }

    public void StartMoon() {
        GameManager.currentPlanet = GameManager.PlanetType.moon;
        StartLevel();
    }

    public void StartJupiter() {
        GameManager.currentPlanet = GameManager.PlanetType.jupiter;
        StartLevel();
    }

    public void StartLevel() {
        SceneManager.LoadScene("Game");
    }


}
