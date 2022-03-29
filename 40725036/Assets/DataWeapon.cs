using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    /// <summary>
    /// �Z�����
    /// 1.����t�� float
    /// 2.�����O float
    /// 3.�_�l�ƶq int
    /// 4.�̤j�ƶq int
    /// 5.���j�ɶ� float
    /// 6.�ͦ���m
    /// </summary>
    //Scriptableobject �}���ƪ���
    //�@�� : �N�}������ܦ������x�s��project��
    //CreateAssetMenu �P Scriptableobject �f�t�ϥ�
    //�@�� : �bProject �إߦ��}���ƪ��󪺿��P�ɮצW��
    // menuName ���W�١BfileName �ɮצW��
    [CreateAssetMenu(menuName = "Tnu40725036/Date Weapon", fileName ="Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public int countStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public int countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        //�������[]�}�C - ��Ƶ��c
        //�@�� : �x�s�h���ۦP���������
        [Header("�ͦ���m")]
        public Vector3[ ] v3SpawnPoint;

    } 
}
