using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score01 = 0;
    public static int score02 = 0;

    //Remember to drag these to the inspector from the hiearchy out in Unity
    public Text scoreText01;
    public Text scoreText02;

    void Update()
    {
        scoreText01.text = score01.ToString();
        scoreText02.text = score02.ToString();
    }

   
}
