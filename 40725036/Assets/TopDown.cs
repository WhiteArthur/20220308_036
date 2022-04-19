using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class TopDown : MonoBehaviour
    {

        #region ���:�O�s�t�λݭn���򥻸�ơA�Ҧp:���ʳt�סB�ʵe�ѼƦW�ٻP����
        //��� field �y�k:�׹��� ������� ���W�� (���w ��l��);

        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region �ƥ�:�{���J�f ( Unity )�A���Ѷ}�o���X�ʨt�Ϊ����f
        private void Awake()
        {
            //print("����ƥ�@");

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //print ("���Ƴ���ƥ�");
            GetInput();
            Move();
        }
        #endregion

        #region ��k:���������\�� ( ���z���B�t��k�ε{���϶� )
        
        //��k method�y�k
        //�׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{���϶� }
        //void �L�Ǧ^
        
        /// <summary>
        /// ���o���a��J���
        /// ���kAD Horizontal
        /// �W�UWS Vertical
        /// </summary>
        private void GetInput()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            //print("���o�����b�V�ȡG" + h);
            
        }
        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            // �ϥΫD�R�A�ݩ� non-static
            //���W��.�R�A�ݩʦW�� ���w ��
            rig.velocity = new Vector2 (h , v) * speed;

            ani.SetBool(parameterRun, h != 0 || v != 0);

            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion

    }
}
