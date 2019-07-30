using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpaceFade : MonoBehaviour
{
    public float FlashAmount;
    float timeleft;
    float time;
    bool Flipper;
    public int Flashes = 8;

    // can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<Text>()));
        }
        timeleft = timeleft - Time.deltaTime;
        if (timeleft <= 0 && FlashAmount < Flashes)
        {
            Flipper = !Flipper;
            timeleft = time;

            if (Flipper == true)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
                FlashAmount = FlashAmount + 1;
            }
            if (Flipper == false)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<Text>()));
            }



            StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));

        }



        IEnumerator FadeTextToFullAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
            while (i.color.a < 1.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
                yield return null;
            }
        }

        IEnumerator FadeTextToZeroAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
            while (i.color.a > 0.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
                yield return null;
            }
        }
    }
}