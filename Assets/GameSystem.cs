using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class GameSystem : MonoBehaviour
{
    public static float ENDTime;

    //スタートを押したら実行する
    public void StartGame()
    {
        SceneManager.LoadScene("game");
        ENDTime = 32.0f;
    }
    
}
