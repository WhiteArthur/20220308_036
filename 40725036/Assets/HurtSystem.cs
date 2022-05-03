using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{

    public class HurtSystem : MonoBehaviour
    {
        // public 公開 :所有類別可存取
        // private 私人 :僅限此類別可存取 
        // protected 保護 :僅限此類別與子類別可存取 
        [SerializeField, Header("血量"),Range(0,10000)]
        protected float hp = 50;
        
        public void GetHurt(float damage)
        {
            hp -= damage;
            print("<color=#887700>受到傷害:" + damage + "</color>");

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            hp = 0;
            print("<color=#887700>角色死亡:" + gameObject + "</color>");
        }

    }
}
