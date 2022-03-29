using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{


    public class Weaponsystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        /// <summary>
        /// �p�ɾ�
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
            print("�g�L���ɶ� : " + timer);
        }
    }
}