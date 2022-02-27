using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    CircleScript Circle1, Circle2, Circle3;
    [SerializeField]
    GameObject redBtn, greenBtn, blueBtn, cyanBtn, magBtn, yellowBtn, easyBtn, normalBtn, hardBtn, PlayBtn, StartCanvas, GameCanvas;
    public Slider timerSlider;
    public Text TimeText;
    private bool stopTimer;
    public CircleScript m_CS;
    public int circles = 0;
    public int colourEnum;
    bool TimeOut = false;
    public float Timer = 90f;
    //public int colourEnum;
    public int Diff;
    private bool active = false;
    private bool positiveCol;
    private bool negativeCol;
    Color Red = Color.red;
    Color Green = Color.green;
    Color Blue = Color.blue;
    Color Cyan = Color.cyan;
    Color Magenta = Color.magenta;
    Color Yellow = Color.yellow;
    Color White = Color.white;
    Color Black = Color.black;
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
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //Difficulty();
        //ActiveCircles();
        //ColourSelect();
        colourEnum = Circle1.colourEnum;
        Debug.Log("colourenum: " + Circle1.colourEnum);
        Circle1.gameObject.SetActive(!active);
        Circle2.gameObject.SetActive(active);
        Circle3.gameObject.SetActive(active); 
    }

    void loseCondition()
    {
        Application.Quit();
    }
    void winCondition()
    {


    }
    public void nextRnd()
    {
        //active = !active;
        if (this.Circle1.solved == true)
        {
            Circle2.ColourSelect();
            Circle1.gameObject.SetActive(!active);
            Circle2.gameObject.SetActive(!active);
            Circle3.gameObject.SetActive(active);
        }
        if (Circle2.solved == true)
        {
            //circles += 1;
            Circle3.ColourSelect();
            Circle1.gameObject.SetActive(!active);
            Circle2.gameObject.SetActive(!active);
            Circle3.gameObject.SetActive(!active);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        if ((Circle1.m_background.GetComponent<SpriteRenderer>().color == Red || Circle1.m_background.GetComponent<SpriteRenderer>().color == Green || Circle1.m_background.GetComponent<SpriteRenderer>().color == Blue || Circle1.m_background.GetComponent<SpriteRenderer>().color == White)) //&&  Circle1.hasChanged == false)
        {
            positiveCol = true;
        }
        else
            positiveCol = false;

        //if ((Circle1.GetComponent<SpriteRenderer>().color == Cyan || Circle1.GetComponent<SpriteRenderer>().color == Magenta || Circle1.GetComponent<SpriteRenderer>().color == Yellow || Circle1.GetComponent<SpriteRenderer>().color == White)) //&& Circle1.hasChanged == false)
        //{
        //    negativeCol = true;
        //}
        //else
        //    negativeCol = false;

        //if (positiveCol == true)
        //{
        //    redBtn.gameObject.SetActive(true);
        //    greenBtn.gameObject.SetActive(true);
        //    blueBtn.gameObject.SetActive(true);
        //    cyanBtn.gameObject.SetActive(false);
        //    magBtn.gameObject.SetActive(false);
        //    yellowBtn.gameObject.SetActive(false);
        //    Debug.Log("positiveCol Status, True:" + m_CS.positiveCol);
        //}
        //else if (positiveCol == false)
        //{
        //    redBtn.gameObject.SetActive(false);
        //    greenBtn.gameObject.SetActive(false);
        //    blueBtn.gameObject.SetActive(false);
        //    cyanBtn.gameObject.SetActive(true);
        //    magBtn.gameObject.SetActive(true);
        //    yellowBtn.gameObject.SetActive(true);
        //    Debug.Log("positiveCol Status, False:" + m_CS.positiveCol);
        //}
        //if (negativeCol == true)
        //{
        //    cyanBtn.gameObject.SetActive(true);
        //    magBtn.gameObject.SetActive(true);
        //    yellowBtn.gameObject.SetActive(true);
        //    redBtn.gameObject.SetActive(false);
        //    greenBtn.gameObject.SetActive(false);
        //    blueBtn.gameObject.SetActive(false);
        //    Debug.Log("negativeCol Status, True:" + m_CS.negativeCol);
        //}
        //else if (negativeCol == false)
        //{
        //    cyanBtn.gameObject.SetActive(false);
        //    magBtn.gameObject.SetActive(false);
        //    yellowBtn.gameObject.SetActive(false);
        //    Debug.Log("negativeCol Status, False:" + m_CS.negativeCol);
        //}
        
    }
    //void ColourSelect()
    //{
    //    colourEnum = Random.Range(0, 5);  
    //}
    public void ToggleGame()
    {
        active = !active;
            StartCanvas.SetActive(!active);
            GameCanvas.SetActive(active); 
        //ColourSelect();
        //CountDown();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void easyClick()
    {
        Diff = 0;
        Difficulty();
    }
    public void normalClick()
    {
        Diff = 1;
        Difficulty();
    }

    public void hardClick()
    {
        Diff = 2;
        Difficulty();
    }
    public void Difficulty()
    {
        switch (Diff)
        {
            case 0:
                Timer = 90;
                break;
            case 1:
                Timer = 60;
                break;
            case 2:
                Timer = 30;
                break;
            default:
                Timer = 90;
                break;
        }

        stopTimer = false;
        timerSlider.maxValue = Timer;
        Debug.Log("MaxValue," + timerSlider.maxValue);
        timerSlider.value = Timer;
        Debug.Log("value: " + timerSlider.value);

    }
    //void ActiveCircles()
    //{
        
    //}
    public void CountDown()
    {
        float time = Timer - Time.time;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            loseCondition();
        }

        if (stopTimer == false)
        {
            TimeText.text = textTime;
            timerSlider.value = time;
        }
    }
}
