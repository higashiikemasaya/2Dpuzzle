﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TouchManager.Began += onTouchBegan;
        TouchManager.Ended += (info) =>
        {
            Debug.Log("ボタンが離された時" + info.screenPoint);
        };
    }
void onTouchBegan(TouchInfo info)
    {
        Debug.Log("ボタンが押されたとき" + info.screenPoint);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
