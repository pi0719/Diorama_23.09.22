using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenARMarkerURL : MonoBehaviour
{
    public string url = "https://www.cdaxgth.com/%EA%B8%B0%EC%B0%A8ar"; // ���ϴ� URL�� ����

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}

