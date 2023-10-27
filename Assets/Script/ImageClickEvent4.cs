using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageClickEvent4 : MonoBehaviour
{
    public GameObject canvasMain;
    public GameObject canvasButtonTasty;
    public ARTrackedImageManager trackedImageManager;
    private ARTrackedImage trackedImage;

    private void Awake()
    {
        // AR 이미지를 가져옵니다.
        trackedImage = GetComponent<ARTrackedImage>();
    }

    public void ShowCanvasButtonNavi()
    {
        // Canvas_Main을 비활성화
        canvasMain.SetActive(false);

        // Canvas_Button_tasty 활성화
        canvasButtonTasty.SetActive(true);

        // icons 오브젝트를 AR 이미지의 위치로 이동
        canvasButtonTasty.transform.position = trackedImage.transform.position;
        canvasButtonTasty.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButtonNavi()
    {
        // Canvas_Button_tasty를 비활성화
        canvasButtonTasty.SetActive(false);

        // Canvas_Main을 활성화
        canvasMain.SetActive(true);
    }
}