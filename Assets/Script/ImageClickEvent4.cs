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
        // AR �̹����� �����ɴϴ�.
        trackedImage = GetComponent<ARTrackedImage>();
    }

    public void ShowCanvasButtonNavi()
    {
        // Canvas_Main�� ��Ȱ��ȭ
        canvasMain.SetActive(false);

        // Canvas_Button_tasty Ȱ��ȭ
        canvasButtonTasty.SetActive(true);

        // icons ������Ʈ�� AR �̹����� ��ġ�� �̵�
        canvasButtonTasty.transform.position = trackedImage.transform.position;
        canvasButtonTasty.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButtonNavi()
    {
        // Canvas_Button_tasty�� ��Ȱ��ȭ
        canvasButtonTasty.SetActive(false);

        // Canvas_Main�� Ȱ��ȭ
        canvasMain.SetActive(true);
    }
}