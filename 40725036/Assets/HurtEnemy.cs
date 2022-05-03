using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class HurtEnemy : HurtSystem
    {
        /// <summary>
        /// 敵人受傷:彈出受傷數字
        /// </summary>
        //子類別:父類別 - 繼承語法
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }

}
