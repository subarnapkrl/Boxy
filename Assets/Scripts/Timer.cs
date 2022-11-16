using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    int countDownStartValue=15;
    [SerializeField] Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        CountDownTimer();
    }

    void CountDownTimer()
    {
        if(countDownStartValue>0)
        {
            timerUI.text="TIMER: "+countDownStartValue;
            countDownStartValue--;
            Invoke("CountDownTimer",1.0f);
        }else{
            PlayerManager.isGameOver=true;
            gameObject.SetActive(false);
        }
    }
    
}
