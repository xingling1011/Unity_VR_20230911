using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�l�u�I�쪫��R��
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);   
    }
}
