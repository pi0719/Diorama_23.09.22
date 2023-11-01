using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLButton : MonoBehaviour
{
    public string url = "https://smartstore.naver.com/cjhessalfam/products/4689848301?NaPm=ct%3Dlodqotzs%7Cci%3D4acd74f80e295907fae86d00651c7af7f311a57b%7Ctr%3Dsls%7Csn%3D1031846%7Chk%3Dec250e30881b251d03137d5a50c8d54a1fb0722f"; // 원하는 URL로 변경

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
