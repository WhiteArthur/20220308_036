using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "�M�h";

        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find(namePlayer).transform;

            /*float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 �P 100 �� 0.5 ���ȵ��G :" + result);*/
        }


        private void Update()
        {
           /* a = Mathf.Lerp(a, b, 0.5f);
            print("���յ��G :" + a);*/
            MoveToPlayer();
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}
