using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.InputSystem.Processors;
using UnityEngine.Windows;

public class Firesystem : MonoBehaviour
{
    [Header("�u���l�u�ƶq"), Range(0, 10)]
    public int magazineCount = 7;
    [Header("�l�u�`��"), Range(20, 200)]
    public int bulletTotal = 28;
    [Header("�ثe�l�u�ƶq"), Range(0, 10)]
    public int bulletCurrent = 7;
    [Header("�l�u�w�s��")]
    public GameObject prefabBullet;
    [Header("�l�u�ͦ��I")]
    public Transform pointSpawnBullet;

    public bool openDoor = true;
    public bool isDead = false;

    private void Awake()
    {
        //print("<color=green>����ƥ�</color>");
        
        
     }

    private void Start()
    {
        //print("<color=red>�}�l�ƥ�</color>");

        if (openDoor) 
        {
            print("�w�g�}��");
        }

        if (isDead) 
        {
            print("�w�g���`");
        }
    }
    private void Update()
    {
        //print("<color=yellow>��s�ƥ�</color>");

       if (UnityEngine.Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Instantiate(prefabBullet);
        }
    }

    
}
