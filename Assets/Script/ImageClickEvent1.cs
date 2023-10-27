using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClickEvent1 : MonoBehaviour
{
    public GameObject Canvas_Button_history;  // Canvas_Button_history ������Ʈ�� ������ ����
    public GameObject Canvas_Main;  // Canvas_Main ������Ʈ�� ������ ����

    // ù ��° �̹����� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
    public void ShowCanvas_Button_history()
    {
        Canvas_Button_history.SetActive(true); // Canvas_Button_history Ȱ��ȭ
        Canvas_Main.SetActive(false); // Canvas_Main ��Ȱ��ȭ
    }

    // Canvas_Button_history ���� ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
    public void HideCanvas_Button_history()
    {
        Canvas_Button_history.SetActive(false); // Canvas_Button_history ��Ȱ��ȭ
        Canvas_Main.SetActive(true); // Canvas_Main Ȱ��ȭ
    }
}
