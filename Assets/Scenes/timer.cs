using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float timeLeft;
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (timeLeft > 0)
       {
        timeLeft -= Time.deltatime;
        UpdateTimer(timeLeft);
       } 
       else
       {
        Debug.Log("Game Over");
        timeLeft = 0;
       }
    }

    void UpdateTimer (float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt (currentTime/60)
        float seconds = Mathf.FloorToInt ()
    }

}
