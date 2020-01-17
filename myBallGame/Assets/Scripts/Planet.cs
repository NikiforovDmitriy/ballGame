using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet", menuName = "Planet")]
public class Planet : ScriptableObject
{
    public float gravity;
    public Color skyColor;

    public void init(float gravity, Color skyColor) {
        this.skyColor = skyColor;
        this.gravity = gravity;
    }
}
