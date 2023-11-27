using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// 讓...暫停(冷卻時間)
/// </summary>
/// 
    //協同程式三個必需條件
    //1. 引用 System.Collections 命名空間
    //2. 定義一個方法並傳回類型為IEnumerator
    //3. 使用 StartCoroutine 啟動
public class LernCoroutine : MonoBehaviour
{
    private IEnumerator test()
    {
        print("<color=#6f9>發五百</color>");
        yield return new WaitForSeconds(2);
        print("<color=#6f9>出小兵</color>");
    }

    private void Awake()
    {
        StartCoroutine(test());
    }
}
