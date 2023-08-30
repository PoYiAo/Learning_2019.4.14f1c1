using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

    public void MainTest()
    {
        //粒子无法被mask遮挡
        //image和RawImage的差别
        //For循环遍历字典，并进行增删操作
        Dictionary<string, object> testDic = new Dictionary<string, object>();
        testDic.Add("test1", 1);
        testDic.Add("test2", 2);
        testDic.Add("test3", 3);
        testDic.Add("test4", 4);
        testDic.Add("test5", 5);

        // for (int i = 0; i < testDic.Keys.Count; i++)
        // {
        //     testDic.Remove(testDic.);
        // }
        
        //不定时钟访问List，如何保证安全性
        //滑动列表有动画，在快速滑动初始化列表时，产生卡顿，如何解决
        //内购，广告，等SDK的接入
    }

    
}
