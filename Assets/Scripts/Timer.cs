using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finished = false;
    public float endTime;
    private float expectedTime = 140; //format = {minutes},{seconds}
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;
        
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        string timermessage = string.Format("{0}:{1}", minutes, seconds); 
        timerText.text = timermessage; 
        endTime = float.Parse(minutes + seconds);
        Debug.Log(timermessage);
    }



    public void finish()
    {
        finished = true;
        if(endTime < expectedTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }
    }
}