using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "騎士";

        private Transform traPlayer;
        /// <summary>
        /// 攻擊計時器
        /// </summary>
        private float timerAttack;
        private Animator ani;
        private string parameterAttack = "觸發攻擊";
        


        private void Awake()
        {
            ani = GetComponent<Animator>();
            traPlayer = GameObject.Find(namePlayer).transform;

            /*float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 與 100 的 0.5 插值結果 :" + result);*/
        }


        private void Update()
        {
           /* a = Mathf.Lerp(a, b, 0.5f);
            print("測試結果 :" + a);*/
            MoveToPlayer();
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0.5f, 0, 0.5f);
            Gizmos.DrawSphere(transform.position, data.stopDistance);
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            float dis = Vector3.Distance(posEnemy, posPlayer);
            //print("<color=yellow>距離:" + dis + "</color>");

            if (dis < data.stopDistance)
            {
                Attack();
            }
            else
            {
                transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

                float y = transform.position.x > traPlayer.position.x ? 180 : 0;
                transform.eulerAngles = new Vector3(0, y, 0);

            }
        }
        private void Attack()
        {
            if (timerAttack < data.cd)
            {
                timerAttack += Time.deltaTime;
                print("<color=red>攻擊計時器:" + timerAttack + "</color>");
            }
            else
            {
                ani.SetTrigger(parameterAttack);
                timerAttack = 0;
            }
        }
    }
}
