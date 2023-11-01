using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageClickEvent3 : MonoBehaviour
{
    public GameObject canvasMain;
    public GameObject canvasButtonNavi;
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

        // Canvas_Button_navi 활성화
        canvasButtonNavi.SetActive(true);

        // icons 오브젝트를 AR 이미지의 위치로 이동
        canvasButtonNavi.transform.position = trackedImage.transform.position;
        canvasButtonNavi.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButtonNavi()
    {
        // Canvas_Button_navi를 비활성화
        canvasButtonNavi.SetActive(false);

        // Canvas_Main을 활성화
        canvasMain.SetActive(true);
    }
}