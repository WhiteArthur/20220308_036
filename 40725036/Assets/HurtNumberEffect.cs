using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tnu40725036
{
    public class HurtNumberEffect : MonoBehaviour
    {
        [SerializeField, Header("睭计"), Range(0, 0.5f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("罽计"), Range(0, 0.5f)]
        private float valueScale = 0.001f;
        [SerializeField, Header("簿计"), Range(0, 0.5f)]
        private float valueOffset = 0.1f;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textHurtNumber;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();
            rect = GetComponent<RectTransform>();
            textHurtNumber = transform.Find("端甡计").GetComponent<Text>();

            //StartCoroutine(Test());
            StartCoroutine(Fade());
            StartCoroutine(Scale());
            StartCoroutine(Offset());

            StartCoroutine(Fade(-1, 0.8f));
            StartCoroutine(Scale(-1, 0.8f));
            StartCoroutine(Offset(-1, 0.8f));
        }

        /// <summary>
        /// 穝端计
        /// </summary>
        /// <param name="damage"></param>
        public void UpdateHurtNumber(float damage)
        {
            textHurtNumber.text = damage.ToString();
        }
        private IEnumerator Test()
        {
            print("材︽");
            yield return new WaitForSeconds(2);
            print("ㄢ材︽");
        }

        private IEnumerator Fade(float add =1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 10;i++)
            {
                group.alpha += valueFade * add;
                yield return new WaitForSeconds(0.02f);

            }
        }
        private IEnumerator Scale(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 5; i++)
            {
                rect.localScale += new Vector3(valueScale, valueScale, 0) * add;
                yield return new WaitForSeconds(0.02f);

            }
        }
        private IEnumerator Offset(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 10; i++)
            {
                rect.anchoredPosition += Vector2.up * valueOffset * add;
                yield return new WaitForSeconds(0.02f);

            }
        }
    }
}
