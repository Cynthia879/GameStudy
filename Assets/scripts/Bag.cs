using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bag : MonoBehaviour
{
     public Sprite expan;
    //private LinkedList<Props> bagList;

    // Start is called before the first frame update
    void Start()
    {
        addProps("道具一",2,expan);
        onShowDesc("vsc vdf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //添加道具到背包
    private void addProps(string propName,int propIndex,Sprite img)
    {
        string findPropBtn="prop"+propIndex;
       Button propBtn=GameObject.Find(findPropBtn).GetComponent<Button>();
       Text text = propBtn.transform.Find("Text").GetComponent<Text>();
        text.text = propName;
         propBtn.GetComponent<Image>().sprite=img ;
       //propBtn.image.sprite = Resources.Load<Sprite>("2DSprites/Xiangkuang");
        
    }

    //显示道具描述信息
    private void onShowDesc(string propDetail)
    {
        Text propdetail=GameObject.Find("propDetail").GetComponent<Text>();
        propdetail.text=propDetail;
    }

    //使用道具
    private void onUse()
    {

    }
}
