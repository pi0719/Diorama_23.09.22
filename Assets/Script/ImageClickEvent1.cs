using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClickEvent1 : MonoBehaviour
{
    public GameObject Canvas_Button_history;  // Canvas_Button_history 오브젝트를 연결할 변수
    public GameObject Canvas_Main;  // Canvas_Main 오브젝트를 연결할 변수

    // 첫 번째 이미지가 클릭되었을 때 호출되는 함수
    public void ShowCanvas_Button_history()
    {
        Canvas_Button_history.SetActive(true); // Canvas_Button_history 활성화
        Canvas_Main.SetActive(false); // Canvas_Main 비활성화
    }

    // Canvas_Button_history 내의 버튼이 클릭되었을 때 호출되는 함수
    public void HideCanvas_Button_history()
    {
        Canvas_Button_history.SetActive(false); // Canvas_Button_history 비활성화
        Canvas_Main.SetActive(true); // Canvas_Main 활성화
    }
}
