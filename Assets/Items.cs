using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public new string name = "Potion";
    public string description = "Attacks";

    public Sprite icon;
    public int attackStrength = 0;


    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        Debug.Log(name + " " + description + " with " + attackStrength);
    }
}
