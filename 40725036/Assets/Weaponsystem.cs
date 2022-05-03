using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        private Animator ATKani;
        [SerializeField, Header("�Z���R���ɶ�"), Range(0, 10)]
        private float destoryWeaponTime = 3.5f;
        /// <summary>
        /// �p�ɾ�
        /// </summary>
        private float timer_f;
        /// <summary>
        /// ø�s�ϥܨƥ�
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
            // 2D ���z.�����ϼh�I��(�ϼh1,�ϼh2)
            Physics2D.IgnoreLayerCollision(3, 6);  // ���a �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 6);  // ���Z�� �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 7);  // �Z�� �P ��� ���I��
            ATKani = gameObject.GetComponent<Animator>();
        }
        private void Update()
        {
            SpawnWeapon();
            //AttackAnimation();
        }
        /// <summary>
        /// �ͦ��Z��
        /// 1.�p��ɶ�
        /// 2.�ɶ��ֿn�춡�j�ɶ�
        /// 3.�ͦ��Z��
        /// 4.���w�b�ͦ���m�W
        /// 5.�o�g�Z��
        /// 6.�ᤩ�Z�������O
        /// </summary>
        private void SpawnWeapon()
        {
            timer_f += Time.deltaTime;
            ATKani.SetBool("�}������", false);
            //print("�g�L���ɶ� : " + timer);
            if (timer_f >= dataWeapon.interval)
            {
                ATKani.SetBool("�}������", true);
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion �|�줸 : �������׸�T
                //Quaternion.identity �s�ר�(0 , 0 , 0)
                //�Ȧs�Z�� = �ͦ� (����A�y�СA����)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.Euler(0, 0, -45));
                //topDown.ani.SetBool(topDown.param,);
                //�Ȧs�Z��.���o����<����>().�K�[��O (��V * �t��)
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
                ATKani.SetBool("�}������", false);
            if (attack == true)
                ATKani.SetBool("�}������", true);
        }
        */
    }
}