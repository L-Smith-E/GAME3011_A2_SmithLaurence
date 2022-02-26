using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    [SerializeField]
    GameManager m_gameManager;

    public int btnVal;

    //enum Colours
    //{
    //    red = 0,
    //    green = 1,
    //    blue = 2,
    //    cyan = 3,
    //    magenta = 4,
    //    yellow = 5,
    //    white = 6,
    //    black = 7
    //}
    [SerializeField]
    public ButtonSelect button;
    public void Start()
    {
        switch (button.tag)
        {
            case "redBtn":
                this.btnVal = (int)GameManager.Colours.red;
                //Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            case "greenBtn":
                this.btnVal = (int)GameManager.Colours.green;
               // Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            case "blueBtn":
                this.btnVal = (int)GameManager.Colours.blue;
               // Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            case "cyanBtn":
                this.btnVal = (int)GameManager.Colours.cyan;
               // Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            case "magBtn":
                this.btnVal = (int)GameManager.Colours.magenta;
              //  Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            case "yellowBtn":
                this.btnVal = (int)GameManager.Colours.yellow;
               // Debug.Log(button + "btnVal = " + this.btnVal);
                break;
            //case "whiteBtn":
            //    this.btnVal = (int)GameManager.Colours.white;
            //   // Debug.Log(button + "btnVal = " + this.btnVal);
            //    break;
            //case "blackBtn":
            //    this.btnVal = (int)GameManager.Colours.black;
            //   // Debug.Log(button + "btnVal = " + this.btnVal);
                break;
        }
    }

    void Click()
    {

    }
}
