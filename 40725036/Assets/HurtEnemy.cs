using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class HurtEnemy : HurtSystem
    {
        /// <summary>
        /// �ĤH����:�u�X���˼Ʀr
        /// </summary>
        //�l���O:�����O - �~�ӻy�k
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }

}
