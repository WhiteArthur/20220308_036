using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class Weaponsystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
        /// <summary>
        /// 計時器
        /// </summary>
        private float timer;
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);

            
            
            for (int  i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
            
        }
        /// <summary>
        /// 生成武器
        /// 1.計算時間
        /// 2.時間累積到間隔時間
        /// 3.生成武器
        /// 4.指定在生成位置上
        /// 5.發射武器
        /// 6.賦予武器攻擊力
        /// </summary>
        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            print("經過的時間 : " + timer);
        }
    }
}