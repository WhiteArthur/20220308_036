using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class WeaponSystem2 : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;

        /// <summary>
        /// �p�ɾ�
        /// </summary>
        private float timer;
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
        private void Update()
        {
            SpawnWeapon();
        }
        private void Start()
        {
            // 2D ���z.�����ϼh�I��(�ϼh1,�ϼh2)
            Physics2D.IgnoreLayerCollision(3, 6);  // ���a �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 6);  // ���Z�� �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 7);  // �Z�� �P ��� ���I��
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