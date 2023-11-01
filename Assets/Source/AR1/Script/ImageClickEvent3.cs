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
        // AR �̹����� �����ɴϴ�.
        trackedImage = GetComponent<ARTrackedImage>();
    }

    public void ShowCanvasButtonNavi()
    {
        // Canvas_Main�� ��Ȱ��ȭ
        canvasMain.SetActive(false);

        // Canvas_Button_navi Ȱ��ȭ
        canvasButtonNavi.SetActive(true);

        // icons ������Ʈ�� AR �̹����� ��ġ�� �̵�
        canvasButtonNavi.transform.position = trackedImage.transform.position;
        canvasButtonNavi.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButtonNavi()
    {
        // Canvas_Button_navi�� ��Ȱ��ȭ
        canvasButtonNavi.SetActive(false);

        // Canvas_Main�� Ȱ��ȭ
        canvasMain.SetActive(true);
    }
}