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

        [SerializeField, Header("經驗值")]
        private Image imgExp;
        [SerializeField, Header("等級")]
        private Text textLv;
        [SerializeField, Header("經驗值需求表")]
        private int[] expsNeed;
        [SerializeField, Header("武器資料1")]
        private DataWeapon dataWeapon_1;
        [SerializeField, Header("武器資料2")]
        public DataWeapon dataWeapon_2;



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
        ///  獲得經驗值
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
            dataWeapon_1.attack += 10;
            dataWeapon_1.interval -= 0.02f;

            dataWeapon_2.attack += 15;
            dataWeapon_2.interval -= 0.05f;
        }
        private void LevelZero()
        {
            dataWeapon_1.attack = 10;
            dataWeapon_1.interval = 0.4f;
            dataWeapon_2.attack = 20;
            dataWeapon_2.interval = 3.5f;
        }
    }
    
}
