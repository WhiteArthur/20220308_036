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
        [SerializeField, Header("�e���ˮ`�ƭ�")]
        private GameObject goCanvasHurt;

        private string parameterDead = "�ĤH���`";
        private Animator ani;
        private EnemySystem enemySystem;

        private void Start()
        {
            ani = GetComponent<Animator>();
            enemySystem = GetComponent<EnemySystem>();

            hp = data.hp;
        }

        public override void GetHurt(float damage)
        {
            base.GetHurt(damage);

            GameObject temp = Instantiate(goCanvasHurt, transform.position, Quaternion.identity);

            temp.GetComponent<HurtNumberEffect>().UpdateHurtNumber(damage);

        }

        protected override void Dead()
        {
            base.Dead();

            ani.SetTrigger(parameterDead);
            enemySystem.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 2);
        }
    }

}
