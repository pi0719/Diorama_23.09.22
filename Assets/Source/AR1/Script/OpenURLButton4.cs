using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLButton4 : MonoBehaviour
{
    public string url = "about:blank"; // ���ϴ� URL�� ����

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
