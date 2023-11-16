using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class info : MonoBehaviour
{
    public GameObject infocanvas;
    public GameObject nowcanvas;
    public ARTrackedImageManager trackedImageManager;
    private ARTrackedImage trackedImage;

    private void Awake()
    {
        // AR 이미지를 가져옵니다.
        trackedImage = GetComponent<ARTrackedImage>();
    }

    public void ShowCanvasButton()
    {
        // Canvas_Main을 비활성화
        infocanvas.SetActive(false);

        // Canvas_Button_tasty 활성화
        nowcanvas.SetActive(true);

        // icons 오브젝트를 AR 이미지의 위치로 이동
        nowcanvas.transform.position = trackedImage.transform.position;
        nowcanvas.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButton()
    {
        // Canvas_Button_tasty를 비활성화
        nowcanvas.SetActive(false);

        // Canvas_Main을 활성화
        infocanvas.SetActive(true);
    }
}
