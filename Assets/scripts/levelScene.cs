using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
       if(GUI.Button(new Rect(100,100,200,100),"背景")){
           BackGroud();}
      if(GUI.Button(new Rect(100,240,200,100),"关卡一")){
           Level(1);
       }
       if(GUI.Button(new Rect(UnityEngine.Screen.width-200,50,60,40),"背包")){
           ShowBag();
       }
        if(GUI.Button(new Rect(UnityEngine.Screen.width-120,50,60,40),"设置")){
           Setting();
       }
        if(GUI.Button(new Rect(UnityEngine.Screen.width-200,UnityEngine.Screen.height-200,140,70),"重新开始")){
           Setting();
       }
    }

    //开始背景介绍的关卡
    private void BackGroud(){
   print("游戏背景");
    }
    private void Level(int levelNum){}

    private void ShowBag(){}
    private void Setting(){}
}
