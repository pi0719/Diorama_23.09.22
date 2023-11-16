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
        // AR �̹����� �����ɴϴ�.
        trackedImage = GetComponent<ARTrackedImage>();
    }

    public void ShowCanvasButton()
    {
        // Canvas_Main�� ��Ȱ��ȭ
        infocanvas.SetActive(false);

        // Canvas_Button_tasty Ȱ��ȭ
        nowcanvas.SetActive(true);

        // icons ������Ʈ�� AR �̹����� ��ġ�� �̵�
        nowcanvas.transform.position = trackedImage.transform.position;
        nowcanvas.transform.rotation = trackedImage.transform.rotation;
    }

    public void HideCanvasButton()
    {
        // Canvas_Button_tasty�� ��Ȱ��ȭ
        nowcanvas.SetActive(false);

        // Canvas_Main�� Ȱ��ȭ
        infocanvas.SetActive(true);
    }
}
