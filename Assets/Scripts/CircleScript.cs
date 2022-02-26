using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    [SerializeField]
    GameManager m_gameManager;
    [SerializeField]
    GameObject redBtn, greenBtn, blueBtn, cyanBtn, magBtn, yellowBtn; //whiteBtn, blackBtn;
    [SerializeField]
    public SpriteRenderer m_SpriteRenderer;
    Color colorVal;
    Color Red = Color.red;
    Color Green = Color.green;
    Color Blue = Color.blue;
    Color Cyan = Color.cyan;
    Color Magenta = Color.magenta;
    Color Yellow = Color.yellow;
    Color White = Color.white;
    Color Black = Color.black;
    //Color colorSol;
    public SpriteRenderer m_background;

    public bool solved = false;
    int BtnVal;
    bool hasChanged = false;
    bool positiveCol;
    bool negativeCol;

    delegate void clickDelegate(ButtonSelect Btn);
    clickDelegate click;

    

    // Start is called before the first frame update
    void Start()
    {
        //click = OnClick;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.gray;
        m_background = this.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        
    }

    
    
    
   

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().color == Red || GetComponent<SpriteRenderer>().color == Green || GetComponent<SpriteRenderer>().color == Blue)
        {
            positiveCol = true;
        }
        else
            positiveCol = false;

        if (GetComponent<SpriteRenderer>().color == Cyan || GetComponent<SpriteRenderer>().color == Magenta || GetComponent<SpriteRenderer>().color == Yellow)
        {
            negativeCol = true;
        }
        else
            negativeCol = false;
        //Debug.Log("Colour: " + BtnVal);
        //ColourShift();
        //if (hasChanged == true)
        //{
        //    if (BtnVal == 0)
        //    {
        //        colorVal = Color.red;
        //        ColourShift(colorVal);
        //    }
        //    else if (BtnVal == 1)
        //    {
        //        colorVal = Color.green;
        //        ColourShift(colorVal);
        //    }
        //    else if (BtnVal == 2)
        //    {
        //        colorVal = Color.blue;
        //        ColourShift(colorVal);
        //    }
        //    else if (BtnVal == 3)
        //    {
        //        colorVal = Color.cyan;
        //        ColourShift(colorVal);
        //    }
        //    else if (BtnVal == 4)
        //    {
        //        colorVal = Color.magenta;
        //        ColourShift(colorVal);
        //    }
        //    else if (BtnVal == 5)
        //    {
        //        colorVal = Color.yellow;
        //        ColourShift(colorVal);
        //    }
        //else if (BtnVal == 6)
        //{
        //    colorVal = Color.white;
        //    ColourShift(colorVal);
        //}
        //else if (BtnVal == 7)
        //{
        //    colorVal = Color.black;
        //    ColourShift(colorVal);
        //}
        //}
        //GetComponent<SpriteRenderer>().color = colorVal;
        ////Debug.Log("Update, BtnVal: " + BtnVal);
        //Debug.Log("Update, colorVal: " + colorVal);

    }
    
    public void redClick(ButtonSelect button)
    {
        BtnVal = 0;
        Debug.Log(button + " pressed");
        hasChanged = true;
        //Debug.Log("Red + : " + (Color.red + Color.green));
        //Debug.Log("Red - Cyan: " + (Color.red - Color.cyan));
        if (hasChanged == true)
        {
            colorVal = Red;
            ColourShift(colorVal);
        }
        
    }

    public void greenClick(ButtonSelect button)
    {
        BtnVal = 1;
        Debug.Log(button + " pressed");
        hasChanged = true;
        if (hasChanged == true)
        {
            colorVal = Green;
            ColourShift(colorVal);
        }
    }

    public void blueClick(ButtonSelect button)
    {
        BtnVal = 2;
        Debug.Log(button + " pressed");
        hasChanged = true;
        if (hasChanged == true)
        {
            colorVal = Blue;
            ColourShift(colorVal);
        }
    }

    public void cyanClick(ButtonSelect button)
    {
        BtnVal = 3;
        Debug.Log(button + " pressed");
        hasChanged = true;
    }

    public void magClick(ButtonSelect button)
    {
        BtnVal = 4;
        Debug.Log(button + " pressed");
        hasChanged = true;
    }

    public void yellowClick(ButtonSelect button)
    {
        BtnVal = 5;
        Debug.Log(button + " pressed");
        hasChanged = true;
    }
    public void ColourShift(Color col)
    {
        bool m_add = true;

        if (m_SpriteRenderer.color == Red)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {
                        colorVal = Red;
                    }
                    else if (col == Green)
                    {
                        colorVal = Yellow; 
                    }
                    else if (col == Blue)
                    {
                        colorVal = Magenta;
                    }
                    //else if (col == Cyan)
                    //{
                    //    colorVal = Black;
                    //}
                    //else if (col == Magenta)
                    //{

                    //}
                    //else if (col == Yellow)
                    //{

                    //}
                    else if (col == White)
                    {
                        colorVal = Red;
                    }
                    //else if (col == Black)
                    //{

                    //}
                    break;
                    
                case false:
                    //if (col == Red)
                    //{
                    //    colorVal = Cyan;
                    //}
                    //else if (col == Green)
                    //{

                    //}
                    //else if (col == Blue)
                    //{

                    //}
                    if (col == Cyan)
                    {
                        colorVal = Green;
                    }
                    else if (col == Magenta)
                    {
                        colorVal = Red;
                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break; 
            }
        }
        if (m_SpriteRenderer.color == Green)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {
                        colorVal = Yellow;
                    }
                    else if (col == Green)
                    {
                        colorVal = Green;
                    }
                    else if (col == Blue)
                    {
                        colorVal = Cyan;
                    }
                    //else if (col == Cyan)
                    //{

                    //}
                    //else if (col == Magenta)
                    //{

                    //}
                    //else if (col == Yellow)
                    //{

                    //}
                    else if (col == White)
                    {
                        colorVal = Green;
                    }
                    //else if (col == Black)
                    //{

                    //}
                    break;

                case false:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;
            }
        }
        if (m_SpriteRenderer.color == Blue)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {
                        colorVal = Magenta;
                    }
                    else if (col == Green)
                    {
                        colorVal = Magenta;
                    }
                    else if (col == Blue)
                    {
                        colorVal = Blue;
                    }
                    //else if (col == Cyan)
                    //{

                    //}
                    //else if (col == Magenta)
                    //{

                    //}
                    //else if (col == Yellow)
                    //{

                    //}
                    else if (col == White)
                    {
                        colorVal = Blue;
                    }
                    //else if (col == Black)
                    //{

                    //}
                    break;

                case false:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;
            }
        }
        if (m_SpriteRenderer.color == Cyan)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;

                case false:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;
            }
        }
        if (m_SpriteRenderer.color == Magenta)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;

                case false:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;
            }
        }
        if (m_SpriteRenderer.color == Yellow)
        {
            switch (m_add)
            {
                case true:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;

                case false:
                    if (col == Red)
                    {

                    }
                    else if (col == Green)
                    {

                    }
                    else if (col == Blue)
                    {

                    }
                    else if (col == Cyan)
                    {

                    }
                    else if (col == Magenta)
                    {

                    }
                    else if (col == Yellow)
                    {

                    }
                    //else if (col == White)
                    //{

                    //}
                    //else if (col == Black)
                    //{

                    //}
                    break;
            }
        }
        //if (m_SpriteRenderer.color == White)
        //{
        //    if (m_add == false)
        //    {
        //        m_add = true;
        //    }
        //}
        //if (m_SpriteRenderer.color == Black)
        //{
        //    if (m_add == true)
        //    {
        //        m_add = false;
        //    }      
        //}
        GetComponent<SpriteRenderer>().color = colorVal;
    }

    

    public void whiteClick(ButtonSelect button)
    {
        BtnVal = 6;
        Debug.Log(button + " pressed");
        hasChanged = true;
    }

    public void blackClick(ButtonSelect button)
    {
        BtnVal = 7;
        Debug.Log(button + " pressed");
        hasChanged = true;
    }
    public void OnClick(ButtonSelect button)
    {
        
        if (button.tag == "redBtn")
        {
            Debug.Log(button + " pressed");
            m_SpriteRenderer.color = Color.red;
            BtnVal = 0; //button.btnVal;
        }
        if (button.tag == "greenBtn")
        {
            Debug.Log(button + " pressed");
            m_SpriteRenderer.color = Color.green;
            BtnVal = 1;//button.btnVal;
        }
        if (button.tag == "blueBtn")
        {
            Debug.Log(button + " pressed");
            m_SpriteRenderer.color = Color.blue;
            BtnVal = 2; //button.btnVal;
        }
        else if (button.tag == "cyanBtn")
        {
            Debug.Log(button + " pressed");
            BtnVal = button.btnVal;
        }
        else if (button.tag == "magBtn")
        {
            Debug.Log(button + " pressed");
            BtnVal = button.btnVal;
        }
        else if (button.tag == "yellowBtn")
        {
            Debug.Log(button + " pressed");
            BtnVal = button.btnVal;
        }
        else if (button.tag == "whiteBtn")
        {
            Debug.Log(button + " pressed");
            BtnVal = button.btnVal;
        }
        else if (button.tag == "blackBtn")
        {
            Debug.Log(button + " pressed");
            BtnVal = button.btnVal;
        }
        Debug.Log("OnClick, Colour: " + BtnVal);
    }
    void ActiveCircles()
    {
        //first circle
        if (m_gameManager.circles == 0)
        {
            if (this.tag == "C2" || this.tag == "C3")
            {
                this.m_SpriteRenderer.enabled = false;
            }
            //else if (this.tag == "C1")
            //{
            //    this.m_SpriteRenderer.enabled = true;
            //}
        }
        //second circle
        else if (m_gameManager.circles == 1)
        {
            if (this.tag == "C1" || this.tag == "C3")
            {
                this.m_SpriteRenderer.enabled = false;
            }
            else
                this.m_SpriteRenderer.enabled = true;
        }
        //third circle
        else if (m_gameManager.circles == 2)
        {
            if (this.tag == "C1" || this.tag == "C2")
            {
                this.m_SpriteRenderer.enabled = false;
            }
            else
                this.m_SpriteRenderer.enabled = true;
        }
        else
            this.m_SpriteRenderer.enabled = true;
    }
}
