//using System;
using UnityEngine;

public class Firesystem : MonoBehaviour
{
    #region ���
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

    [Header("�}�j�ʵe�Ѽ�")]
    public string parFire = "Ĳ�o�}�j";
    [Header("�ʵe���")]
    public Animator ani;
    [Header("���Ĩӷ�")]
    public AudioSource aud;
    [Header("�}�j����")]
    public AudioClip soundFire;
    #endregion
    /*
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
    */
    private void Update()
    {
        //print("<color=yellow>��s�ƥ�</color>");

       if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            ani.SetTrigger(parFire);
            Instantiate(prefabBullet,pointSpawnBullet.position, pointSpawnBullet.rotation );

            float volume = Random.Range(0.8f, 3.2f);
            aud.PlayOneShot(soundFire,volume);
        }

        

    }

    
}
