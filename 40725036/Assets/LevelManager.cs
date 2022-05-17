using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tnu40725036
{
    public class LevelManager : MonoBehaviour
    {
        private int lv = 1;
        private int exp;
        private int expMax;

        [SerializeField, Header("�g���")]
        private Image imgExp;
        [SerializeField, Header("����")]
        private Text textLv;
        [SerializeField, Header("�g��ȻݨD��")]
        private int[] expsNeed;
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;

        [ContextMenu("Setting Exps Need")]
        private void SettingExpsNeed()
        {
            expsNeed = new int[99];
            
            for (int i = 0; i < expsNeed.Length; i++)
            {
                expsNeed[i] = (i + 1) * 100;
            }
        }

        
        private void Start()
        {
            LevelZero();
        }
        /// <summary>
        ///  ��o�g���
        /// </summary>
        /// <param name="getExp"></param>
        public void GetExp(int getExp)
        {
            exp += getExp;
            expMax = expsNeed[lv - 1];

            while(exp >= expMax)
            {
                lv++;
                exp -= expMax;
                expMax = expsNeed[lv - 1];

                LevelUp();
            }

            imgExp.fillAmount = (float)exp / (float)expMax;
            textLv.text = "Lv." + lv;
        }
        private void LevelUp()
        {
            dataWeapon.attack += 10;
            dataWeapon.interval -= 0.02f;
        }
        private void LevelZero()
        {
            dataWeapon.attack = 10;
        }
    }
    
}
