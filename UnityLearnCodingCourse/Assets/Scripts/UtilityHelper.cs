using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityHelper 
{
    public static Renderer rend;
    //make a set of colours
    //public static List<Color> colours;

    public static void ChangeColour(Renderer rend, Color colour, bool randomColour = false)
    {
        //pass through a gameObject's renderer material and the desired colour
        //set the colour of that renderer to a new colour
        if (randomColour)
        {
            colour = new Color(Random.value, Random.value, Random.value);
        }
        rend.material.color = colour;
    }

    public static void RandomColour(Renderer rend, List<Color> colours)
    {
        //get a gameObject's material renderer
        //set the colour of that renderer to a new colour
        int i = Random.Range(0, colours.Count);
        rend.material.color = colours[i];
    }
}
