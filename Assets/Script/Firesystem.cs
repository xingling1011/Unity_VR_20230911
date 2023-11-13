//using System;
using UnityEngine;

public class Firesystem : MonoBehaviour
{
    #region 戈
    [Header("紆Ж紆计秖"), Range(0, 10)]
    public int magazineCount = 7;
    [Header("紆羆计"), Range(20, 200)]
    public int bulletTotal = 28;
    [Header("ヘ玡紆计秖"), Range(0, 10)]
    public int bulletCurrent = 7;
    [Header("紆箇籹")]
    public GameObject prefabBullet;
    [Header("紆ネΘ翴")]
    public Transform pointSpawnBullet;

    [Header("秨簀笆礶把计")]
    public string parFire = "牟祇秨簀";
    [Header("笆礶北竟")]
    public Animator ani;
    [Header("ㄓ方")]
    public AudioSource aud;
    [Header("秨簀")]
    public AudioClip soundFire;
    #endregion
    /*
        public bool openDoor = true;
        public bool isDead = false;

        private void Awake()
        {
            //print("<color=green>酬眶ㄆン</color>");


         }

        private void Start()
        {
            //print("<color=red>秨﹍ㄆン</color>");

            if (openDoor) 
            {
                print("竒秨");
            }

            if (isDead) 
            {
                print("竒");
            }

        }
    */
    private void Update()
    {
        //print("<color=yellow>穝ㄆン</color>");

       if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            ani.SetTrigger(parFire);
            Instantiate(prefabBullet,pointSpawnBullet.position, pointSpawnBullet.rotation );

            float volume = Random.Range(0.8f, 3.2f);
            aud.PlayOneShot(soundFire,volume);
        }

        

    }

    
}
