using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClickEvent2 : MonoBehaviour
{
    public GameObject Canvas_Button_product;  // Canvas_Button_product ������Ʈ�� ������ ����
    public GameObject Canvas_Main;  // Canvas_Main ������Ʈ�� ������ ����

    // ù ��° �̹����� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
    public void ShowCanvas_Button_product()
    {
        Canvas_Button_product.SetActive(true); // Canvas_Button_product Ȱ��ȭ
        Canvas_Main.SetActive(false); // Canvas_Main ��Ȱ��ȭ
    }

    // Canvas_Button_history ���� ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
    public void HideCanvas_Button_product()
    {
        Canvas_Button_product.SetActive(false); // Canvas_Button_product ��Ȱ��ȭ
        Canvas_Main.SetActive(true); // Canvas_Main Ȱ��ȭ
    }

}