using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class WeaponSystem2 : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;

        /// <summary>
        /// 計時器
        /// </summary>
        private float timer;
        /// <summary>
        /// 繪製圖示事件
        /// </summary>
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);



            for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }

        }
        private void Update()
        {
            SpawnWeapon();
        }
        private void Start()
        {
            // 2D 物理.忽略圖層碰撞(圖層1,圖層2)
            Physics2D.IgnoreLayerCollision(3, 6);  // 玩家 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 6);  // 玩武器 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 7);  // 武器 與 牆壁 不碰撞
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
            if (timer >= dataWeapon.interval)
            {

                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.Euler(0, 0, 135));
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);
                timer = 0;
            }
            
        }
    }
}