//using System.Collections;
//using System.Collections.Generic;
using TMPro;     //TMP 文字 空間
using UnityEngine;
using UnityEngine.UI;   //Image 文字   空間

namespace Ling
{
    public class DamagePlayer : DamageBasic
    {
        [Header("血條")]
        public TextMeshProUGUI textHP;
        [Header("血條背景圖片")]
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

            //更新文字介面
            textHP.text = hp.ToString();
            //  更新圖片介面
            imageHP.fillAmount = hp/hpMax;
        }
        protected override void Dead()
        {
            base.Dead();
            GameManager.instance.StartShowFinal("Game Over");
        }
    }
    
   
}

