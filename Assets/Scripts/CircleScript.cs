using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    [SerializeField]
    GameManager m_gameManager;
    [SerializeField]
    ButtonSelect redBtn, greenBtn, blueBtn, cyanBtn, magBtn, yellowBtn; //whiteBtn, blackBtn;
    [SerializeField]
    public SpriteRenderer m_SpriteRenderer;
    Color colorVal;
    Color bgColor;
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
    public int colourEnum;
    public bool solved = false;
    int BtnVal;
    public bool hasChanged = false;
    public bool positiveCol;
    public bool negativeCol;

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

    delegate void clickDelegate(ButtonSelect Btn);
    clickDelegate click;

    


    // Start is called before the first frame update
    void Start()
    {
        ColourSelect();
        //click = OnClick;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.gray;
        m_background = this.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        this.positiveCol = true;
        this.negativeCol = true;
        //Debug.Log("Start, This.PositiveCol " + this.positiveCol);
        //Debug.Log("Start, this.negativeCol " + this.negativeCol);
        IEnumerable<ButtonSelect> my_slist = BtnList();
        switch (colourEnum)
        {
            
            case 0:
                bgColor = Red;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            case 1:
                bgColor = Green;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            case 2:
                bgColor = Blue;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            case 3:
                bgColor = Cyan;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            case 4:
                bgColor = Magenta;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            case 5:
                bgColor = Yellow;
                m_background.GetComponent<SpriteRenderer>().color = bgColor;
                foreach (var item in my_slist)
                {
                    item.btnActive(item.btnVal, colourEnum);
                }
                break;
            default:
                Debug.Log("CS Start, : " + colourEnum);
                break;
        }
    }
    public IEnumerable<ButtonSelect> BtnList()
    {
        List<ButtonSelect> my_list = new List<ButtonSelect>()
        {redBtn, greenBtn, blueBtn, cyanBtn, magBtn, yellowBtn};

        foreach (var items in my_list)
        {
            yield return items;
        }

    }

    // Update is called once per frame
    void Update()
    {

        
        //switch (colourEnum)
        //{
        //    case 0:
        //        bgColor = Red;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //    case 1:
        //        bgColor = Green;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //    case 2:
        //        bgColor = Blue;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //    case 3:
        //        bgColor = Cyan;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //    case 4:
        //        bgColor = Magenta;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //    case 5:
        //        bgColor = Yellow;
        //        m_background.GetComponent<SpriteRenderer>().color = bgColor;
        //        break;
        //}
        
    }
    
    public void ColourSelect()
    {
        colourEnum = Random.Range(0, 5);
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
        if (GetComponent<SpriteRenderer>().color == m_background.color)
        {
            this.solved = true;
            m_gameManager.nextRnd();
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
        if (GetComponent<SpriteRenderer>().color == m_background.color)
        {
            this.solved = true;
            m_gameManager.nextRnd();
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
        if (GetComponent<SpriteRenderer>().color == m_background.color)
        {
            this.solved = true;
            m_gameManager.nextRnd();
        }
    }

    public void cyanClick(ButtonSelect button)
    {
        BtnVal = 3;
        Debug.Log(button + " pressed");
        hasChanged = true;
        if (hasChanged == true)
        {
            colorVal = Cyan;
            ColourShift(colorVal);
        }
        if (GetComponent<SpriteRenderer>().color == m_background.color)
        {
            this.solved = true;
            m_gameManager.nextRnd();
        }
    }

    public void magClick(ButtonSelect button)
    {
        BtnVal = 4;
        Debug.Log(button + " pressed");
        hasChanged = true;
        if (hasChanged == true)
        {
            colorVal = Magenta;
            ColourShift(colorVal);
        }
        //if (GetComponent<SpriteRenderer>().color == m_background.color)
        //{
        //    this.solved = true;
        //    m_gameManager.nextRnd();
        //}
    }

    public void yellowClick(ButtonSelect button)
    {
        BtnVal = 5;
        Debug.Log(button + " pressed");
        hasChanged = true;
        if (hasChanged == true)
        {
            colorVal = Yellow;
            ColourShift(colorVal);
        }
        if (GetComponent<SpriteRenderer>().color == m_background.color)
        {
            this.solved = true;
            m_gameManager.nextRnd();
        }
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
                        colorVal = Cyan;
                        
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
                    //if (col == Red)
                    //{

                    //}
                    //else if (col == Green)
                    //{

                    //}
                    //else if (col == Blue)
                    //{

                    //}
                    if (col == Cyan)
                    {
                        colorVal = Cyan;
                        
                    }
                    else if (col == Magenta)
                    {
                        colorVal = Blue;
                        
                    }
                    else if (col == Yellow)
                    {
                        colorVal = Green;
                        
                    }
                    else if (col == White)
                    {
                        colorVal = Cyan;
                        
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
        if (m_SpriteRenderer.color == Magenta)
        {
            switch (m_add)
            {
                case true:
                    //if (col == Red)
                    //{

                    //}
                    //else if (col == Green)
                    //{

                    //}
                    //else if (col == Blue)
                    //{

                    //}
                    if (col == Cyan)
                    {
                        colorVal = Blue;
                        
                    }
                    else if (col == Magenta)
                    {
                        colorVal = Magenta;
                        
                    }
                    else if (col == Yellow)
                    {
                        colorVal = Red;
                        
                    }
                    else if (col == White)
                    {
                        colorVal = Magenta;
                        
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
        if (m_SpriteRenderer.color == Yellow)
        {
            switch (m_add)
            {
                case true:
                    //if (col == Red)
                    //{

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
                        colorVal = Yellow;
                        
                    }
                    else if (col == White)
                    {
                        colorVal = Yellow;
                        
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
        //if (positiveCol == true)
        //{
        //    redBtn.gameObject.SetActive(true);
        //    greenBtn.gameObject.SetActive(true);
        //    blueBtn.gameObject.SetActive(true);
        //    cyanBtn.gameObject.SetActive(false);
        //    magBtn.gameObject.SetActive(false);
        //    yellowBtn.gameObject.SetActive(false);
        //    Debug.Log("positiveCol Status, True:" + positiveCol);
        //}
        //else if (positiveCol == false)
        //{
        //    redBtn.gameObject.SetActive(false);
        //    greenBtn.gameObject.SetActive(false);
        //    blueBtn.gameObject.SetActive(false);
        //    cyanBtn.gameObject.SetActive(true);
        //    magBtn.gameObject.SetActive(true);
        //    yellowBtn.gameObject.SetActive(true);
        //    Debug.Log("positiveCol Status, False:" + positiveCol);
        //}
        //if (negativeCol == true)
        //{
        //    cyanBtn.gameObject.SetActive(true);
        //    magBtn.gameObject.SetActive(true);
        //    yellowBtn.gameObject.SetActive(true);
        //    redBtn.gameObject.SetActive(false);
        //    greenBtn.gameObject.SetActive(false);
        //    blueBtn.gameObject.SetActive(false);
        //    Debug.Log("negativeCol Status, True:" + negativeCol);
        //}
        //else if (negativeCol == false)
        //{
        //    cyanBtn.gameObject.SetActive(false);
        //    magBtn.gameObject.SetActive(false);
        //    yellowBtn.gameObject.SetActive(false);
        //    Debug.Log("negativeCol Status, False:" + negativeCol);
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
    
}
