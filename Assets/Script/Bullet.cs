using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //子彈碰到物件刪除
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);   
    }
}
