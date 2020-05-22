using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCtrller : MonoBehaviour
{
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //控制开始游戏后的UI
    private void OnGUI()
    {
        if(GUI.Button(new Rect(UnityEngine.Screen.width/2-60,UnityEngine.Screen.height/2-30,120,60),"开始游戏")){
    print("按钮被按下");
    SceneManager.LoadScene("LevelScene");}
    }

    //结束游戏
    public void onGameEnd()
    {
        isGameOver = true;
    }

    //保存背包到本地存储
    public void onSave()
    {

    }
}
