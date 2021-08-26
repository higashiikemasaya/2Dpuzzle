using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class GameSystem : MonoBehaviour
{
    //スタートを押したら実行する
    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }

}
