using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageRecognitionHandler : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject objectToDeactivate; // ��Ȱ��ȭ�� GameObject

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        // �̹����� �νĵǾ��ų� ������Ʈ �Ǿ��� ��
        if (eventArgs.added.Count > 0 || eventArgs.updated.Count > 0)
        {
            foreach (var trackedImage in eventArgs.added)
            {
                ProcessImage(trackedImage);
            }

            foreach (var trackedImage in eventArgs.updated)
            {
                ProcessImage(trackedImage);
            }
        }
    }

    void ProcessImage(ARTrackedImage trackedImage)
    {
        // ���⼭�� �ܼ��� �̹����� �νĵǸ� GameObject�� ��Ȱ��ȭ�մϴ�.
        // �ʿ信 ���� Ư�� �̹����� ���� ó���� �߰��� �� �ֽ��ϴ�.
        if (trackedImage.trackingState == TrackingState.Tracking)
        {
            objectToDeactivate.SetActive(false);
        }
    }
}