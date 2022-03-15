using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tnu40725036
{
    public class TopDown : MonoBehaviour
    {

        #region 資料:保存系統需要的基本資料，例如:移動速度、動畫參數名稱與元件
        //欄位 field 語法:修飾詞 資料類型 欄位名稱 (指定 初始值);
        private float speed = 10.5f;
        private string parameterRun = "開關跑步";
        private string parameterDead = "開關死亡";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 事件:程式入口 ( Unity )，提供開發者驅動系統的窗口
        private void Awake()
        {
            print("喚醒事件一");

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            print ("重複喚醒事件");
        }
        #endregion

        #region 方法:較複雜的功能 ( 陳述式、演算法或程式區塊 )
        #endregion

    }
}
