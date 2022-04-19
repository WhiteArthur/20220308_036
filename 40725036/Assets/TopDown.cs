using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class TopDown : MonoBehaviour
    {

        #region 資料:保存系統需要的基本資料，例如:移動速度、動畫參數名稱與元件
        //欄位 field 語法:修飾詞 資料類型 欄位名稱 (指定 初始值);

        [SerializeField, Header("移動速度"), Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "開關跑步";
        private string parameterDead = "開關死亡";
        
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region 事件:程式入口 ( Unity )，提供開發者驅動系統的窗口
        private void Awake()
        {
            //print("喚醒事件一");

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //print ("重複喚醒事件");
            GetInput();
            Move();
        }
        #endregion

        #region 方法:較複雜的功能 ( 陳述式、演算法或程式區塊 )
        
        //方法 method語法
        //修飾詞 傳回資料類型 方法名稱 (參數) { 程式區塊 }
        //void 無傳回
        
        /// <summary>
        /// 取得玩家輸入資料
        /// 左右AD Horizontal
        /// 上下WS Vertical
        /// </summary>
        private void GetInput()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            //print("取得水平軸向值：" + h);
            
        }
        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            // 使用非靜態屬性 non-static
            //欄位名稱.靜態屬性名稱 指定 值
            rig.velocity = new Vector2 (h , v) * speed;

            ani.SetBool(parameterRun, h != 0 || v != 0);

            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion

    }
}
