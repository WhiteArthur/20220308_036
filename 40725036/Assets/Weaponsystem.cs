using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
        private Animator ATKani;
        [SerializeField, Header("武器刪除時間"), Range(0, 10)]
        private float destoryWeaponTime = 3.5f;
        /// <summary>
        /// 計時器
        /// </summary>
        private float timer_f;
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
        private void Start()
        {
            // 2D 物理.忽略圖層碰撞(圖層1,圖層2)
            Physics2D.IgnoreLayerCollision(3, 6);  // 玩家 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 6);  // 玩武器 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 7);  // 武器 與 牆壁 不碰撞
            ATKani = gameObject.GetComponent<Animator>();
        }
        private void Update()
        {
            SpawnWeapon();
            //AttackAnimation();
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
            timer_f += Time.deltaTime;
            ATKani.SetBool("開關攻擊", false);
            //print("經過的時間 : " + timer);
            if (timer_f >= dataWeapon.interval)
            {
                ATKani.SetBool("開關攻擊", true);
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion 四位元 : 紀錄角度資訊
                //Quaternion.identity 零度角(0 , 0 , 0)
                //暫存武器 = 生成 (物件，座標，角度)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.Euler(0, 0, -45));
                //topDown.ani.SetBool(topDown.param,);
                //暫存武器.取得元件<剛體>().添加堆力 (方向 * 速度)
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);

                timer_f = 0;

                Destroy(temp, destoryWeaponTime);

                temp.GetComponent<Weapon>().attack = dataWeapon.attack;
            }
        }


        /*
        private void AttackAnimation()
        {
            if (Input.GetMouseButtonDown(0))
                attack = true;
            else
                attack = false;
            if (attack == false)
                ATKani.SetBool("開關攻擊", false);
            if (attack == true)
                ATKani.SetBool("開關攻擊", true);
        }
        */
    }
}