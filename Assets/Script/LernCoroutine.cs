using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// ��...�Ȱ�(�N�o�ɶ�)
/// </summary>
/// 
    //��P�{���T�ӥ��ݱ���
    //1. �ޥ� System.Collections �R�W�Ŷ�
    //2. �w�q�@�Ӥ�k�öǦ^������IEnumerator
    //3. �ϥ� StartCoroutine �Ұ�
public class LernCoroutine : MonoBehaviour
{
    private IEnumerator test()
    {
        print("<color=#6f9>�o����</color>");
        yield return new WaitForSeconds(2);
        print("<color=#6f9>�X�p�L</color>");
    }

    private void Awake()
    {
        StartCoroutine(test());
    }
}
