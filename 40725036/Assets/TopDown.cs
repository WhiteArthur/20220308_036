using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class TopDown : MonoBehaviour
    {

        #region ���:�O�s�t�λݭn���򥻸�ơA�Ҧp:���ʳt�סB�ʵe�ѼƦW�ٻP����
        //��� field �y�k:�׹��� ������� ���W�� (���w ��l��);
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{���J�f ( Unity )�A���Ѷ}�o���X�ʨt�Ϊ����f
        private void Awake()
        {
            print("����ƥ�@");

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            print ("���Ƴ���ƥ�");
        }
        #endregion

        #region ��k:���������\�� ( ���z���B�t��k�ε{���϶� )
        #endregion

    }
}
