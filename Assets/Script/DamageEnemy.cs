
using UnityEngine;

public class DamageEnemy : DamageBasic
{
    [Header("�z���S��")]
    public GameObject prefabExplotion;

    private string bulletName = "�l�u";

    //�I���ƥ�: ��Ӫ���I���}�l�ɰ���@��
    //����:
    //1. ��Ӫ��󳣭n���I���� Collider , ������Ϊ�

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            Damage(20);
        }
    }

    //override �[�W�Ů�
    protected override void Dead()
    {
        //�쥻�����O�����e
        base.Dead();
        GameObject temp = Instantiate(prefabExplotion,transform.position,Quaternion.identity);
        
        //���W�R���ĤH gameObject ���C������
        Destroy(gameObject);
        //����0.5��R���z���S��
        Destroy(temp, 0.5f);
    }


      

}
