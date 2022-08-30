using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorObjProperties : MonoBehaviour
{
    //Color[] objColors = new Color[];
    //Color[Color.red, Color.green, Color.blue] objColors = new Color[3];
    public Color[] objColors = new Color[] { Color.green, Color.red, Color.blue};

    public Color objColor;

    // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<Image>().color = objColors[Random.Range(0, 3)];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10));
    }
}
