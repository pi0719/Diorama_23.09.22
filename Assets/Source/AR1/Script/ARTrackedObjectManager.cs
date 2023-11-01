using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.XR.ARFoundation;


public class ARTrackedObjectManager : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject canvasObject;  // Canvas ������Ʈ�� ������ ����

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            Debug.Log("Image Detected!");  // �α� ���
            ShowCanvas();
        }
    }

    void ShowCanvas()
    {
        canvasObject.SetActive(true);  // Canvas Ȱ��ȭ
    }
}
