using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum PlanetType { earth, moon, jupiter };
    public static PlanetType currentPlanet;
    public float ballImpulsePower;
    Planet planet;
    public Camera cam;
    public GameObject ball;
    Rigidbody2D ballRb;
    private Plane plane = new Plane(Vector3.up, Vector3.zero);
    // Start is called before the first frame update
    void Start()
    {
        CreateInstance();
        cam.backgroundColor = planet.skyColor;
        Physics2D.gravity = new Vector3(0, -planet.gravity, 0);
        ballRb = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            var sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "Game")
            {
                SceneManager.LoadScene("Main");
            }
            else {
                Application.Quit();
            }           
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 direction = (mousePos - ball.transform.position).normalized;
            ballRb.AddForce(direction * ballImpulsePower);
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void CreateInstance() {
        planet = ScriptableObject.CreateInstance("Planet") as Planet;
        switch (currentPlanet) {
            case PlanetType.earth:
                planet.init(9.8f, Color.blue);
                break;
            case PlanetType.jupiter:
                planet.init(24.5f, new Color(224f/225f, 131f/255f, 67f/255f));
                break;
            case PlanetType.moon:
                planet.init(1.6f, Color.grey);
                break;

        }
    }
}
