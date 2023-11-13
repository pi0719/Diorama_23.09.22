using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageRecognitionHandler : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject objectToDeactivate; // 비활성화할 GameObject

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
        // 이미지가 인식되었거나 업데이트 되었을 때
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
        // 여기서는 단순히 이미지가 인식되면 GameObject를 비활성화합니다.
        // 필요에 따라 특정 이미지에 대한 처리를 추가할 수 있습니다.
        if (trackedImage.trackingState == TrackingState.Tracking)
        {
            objectToDeactivate.SetActive(false);
        }
    }
}