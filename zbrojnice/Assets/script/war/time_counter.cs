//Jan Kopejtko, 2022

using UnityEngine.UI;
using UnityEngine;

public class time_counter : MonoBehaviour
{
    private float seconds = 0;
    private float minutes = 0;
    private float hours = 0;
    public static int days = 1;
    [SerializeField] int multiplier;
    [SerializeField] Text showTime;
    [SerializeField] Text showDays;
    private void Start()
    {
        seconds = 0;
        minutes = 0;
        hours = 0;
        days = 1;
    }
    void Update()
    {
        seconds += Time.deltaTime * multiplier;
        if (seconds > 59)
        {
            minutes++;
            seconds = 0;
        }
        if (minutes > 59)
        {
            hours++;
            minutes = 0;
        }
        if(hours > 23) 
        {
            days++;
            hours = 0;
        }
        showTime.text = "Time: " + (int)hours + ":" + (int)minutes + ":" + (int)seconds;
        showDays.text = "Day: " + days;
    }
}
