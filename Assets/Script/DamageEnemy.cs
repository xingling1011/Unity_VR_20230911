
using UnityEngine;

public class DamageEnemy : DamageBasic
{
    [Header("爆炸特效")]
    public GameObject prefabExplotion;

    private string bulletName = "子彈";

    //碰撞事件: 兩個物件碰撞開始時執行一次
    //條件:
    //1. 兩個物件都要有碰撞器 Collider , 不限制形狀

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            Damage(20);
        }
    }

    //override 加上空格
    protected override void Dead()
    {
        //原本父類別的內容
        base.Dead();
        GameObject temp = Instantiate(prefabExplotion,transform.position,Quaternion.identity);
        
        //馬上刪除敵人 gameObject 此遊戲物件
        Destroy(gameObject);
        //延遲0.5秒刪除爆炸特效
        Destroy(temp, 0.5f);
    }


      

}
