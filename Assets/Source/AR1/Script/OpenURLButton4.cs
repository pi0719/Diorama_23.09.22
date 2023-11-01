using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLButton4 : MonoBehaviour
{
    public string url = "about:blank"; // 원하는 URL로 변경

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
