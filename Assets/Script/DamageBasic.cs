using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("��q"), Range(0, 1000)]
    public float hp = 100;

    /// <summary>
    /// ������ˤ�k
    /// </summary>
    /// <param name="damage">���쪺�ˮ`��</param>
    public virtual void Damage(float damage)
    {
        //��q ���� �ˮ`��
        hp -= damage;
        //�N��q ����b 0 ~ 1000 ����
        hp = Mathf.Clamp(hp, 0, 1000);
        if (hp <= 0) Dead();
    }

    /// <summary>
    /// ���⦺�`��k
    /// </summary>
    
    // protected �O�@:���\�l���O�ϥ�
    //virtual ����:���\�l���O�мg override

    protected virtual void Dead()
    {
        print("<color=#69f>���`</color>");
    }
}
