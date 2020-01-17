using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    SpriteRenderer render;
    public void Touch()
    {
        var red = Random.Range(0f, 255f);
        var green = Random.Range(0f, 255f);
        var blue = Random.Range(0f, 255f);
        render.color = new Color(red/255f, green/255f, blue/255f);
    }

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        Touch();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Touch();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
