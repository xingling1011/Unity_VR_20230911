//using System.Collections;
//using System.Collections.Generic;
using TMPro;     //TMP ��r �Ŷ�
using UnityEngine;
using UnityEngine.UI;   //Image ��r   �Ŷ�

namespace Ling
{
    public class DamagePlayer : DamageBasic
    {
        [Header("���")]
        public TextMeshProUGUI textHP;
        [Header("����I���Ϥ�")]
        public Image imageHP;

        private float hpMax;

        private void Awake()
        {
            hpMax = hp;
            textHP.text = hp.ToString();
        }

        public override void Damage(float damage)
        {
            base.Damage(damage);

            //��s��r����
            textHP.text = hp.ToString();
            //  ��s�Ϥ�����
            imageHP.fillAmount = hp/hpMax;
        }
        protected override void Dead()
        {
            base.Dead();
            GameManager.instance.StartShowFinal("Game Over");
        }
    }
    
   
}

