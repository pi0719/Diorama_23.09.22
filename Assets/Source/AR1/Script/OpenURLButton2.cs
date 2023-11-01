using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLButton2 : MonoBehaviour
{
    public string url = "https://smartstore.naver.com/yhagriculturalproductsmarket/products/4877994676?NaPm=ct%3Dlodrccg0%7Cci%3D2ee9d152e6330085fe41b5bfa7c6d65c1f69bdca%7Ctr%3Dsls%7Csn%3D1019486%7Chk%3Ddbf2ee046c1ec46a813fe647bb1cb66895326f1f"; // 원하는 URL로 변경

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
