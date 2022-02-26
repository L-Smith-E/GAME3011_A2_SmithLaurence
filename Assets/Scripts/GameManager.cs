using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject Circle1, Circle2, Circle3;
    public int circles = 0;
    bool TimeOut = false;
    float Timer = 30.0f;
    public int colourEnum;
    public enum Colours
    {
        red = 0,
        green = 1,
        blue = 2,
        cyan = 3,
        magenta = 4,
        yellow = 5,
        //white = 6,
        //black = 7
    }

    private void Awake()
    {
        ColourSelect();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void nextRnd()
    {
        ColourSelect();
    }
    void ColourSelect()
    {
        colourEnum = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
