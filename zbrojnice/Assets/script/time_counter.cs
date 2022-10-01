using UnityEngine;
using UnityEngine.UI;

public class time_counter : MonoBehaviour
{
    public static float time = 0;
    private float seconds = 0;
    private float minutes = 0;
    private float hours = 0;
    private int days = 1;
    [SerializeField] int multiplier;
    [SerializeField] Text showTime;
    [SerializeField] Text showDays;
    void Update()
    {
        time += Time.deltaTime * multiplier;
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
