using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    //カウントダウン
    public static float CountDownTime; //カウントダウンタイム
    public Text TextCountDown;         //表示用UI

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = string.Format("{0:00.0}", CountDownTime);
        CountDownTime -= Time.deltaTime;
    }
}
