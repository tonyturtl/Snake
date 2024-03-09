using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float TimeLeft;
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (TimeLeft > 0)
       {
        TimeLeft -= Time.deltaTime;
        UpdateTimer(TimeLeft);
       } 
       else
       {
        Debug.Log("Game Over");
        TimeLeft = 0;
       }
    }

    void UpdateTimer (float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt (currentTime/60);
        float seconds = Mathf.FloorToInt (currentTime%60);

        TimerText.text = string.Format ("{0:00} : {1:00}" ,minutes, seconds);
    }

}
