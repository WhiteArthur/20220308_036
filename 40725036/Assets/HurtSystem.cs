using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{

    public class HurtSystem : MonoBehaviour
    {
        // public ���} :�Ҧ����O�i�s��
        // private �p�H :�ȭ������O�i�s�� 
        // protected �O�@ :�ȭ������O�P�l���O�i�s�� 
        [SerializeField, Header("��q"),Range(0,10000)]
        protected float hp = 50;
        
        public void GetHurt(float damage)
        {
            hp -= damage;
            print("<color=#887700>����ˮ`:" + damage + "</color>");

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            hp = 0;
            print("<color=#887700>���⦺�`:" + gameObject + "</color>");
        }

    }
}
