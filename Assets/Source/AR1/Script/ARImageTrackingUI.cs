using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class ARImageTrackingUI : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;

    private TextMeshProUGUI trackingText;

    void Start()
    {
        // 현재 오브젝트의 TextMeshProUGUI 컴포넌트를 가져옵니다.
        trackingText = GetComponent<TextMeshProUGUI>();
    }

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
        if (eventArgs.added.Count > 0 || eventArgs.updated.Count > 0)
        {
            // 이미지가 인식되었을 때
            trackingText.gameObject.SetActive(false);
        }
        else if (eventArgs.removed.Count > 0)
        {
            // 이미지 인식이 사라졌을 때
            trackingText.gameObject.SetActive(true);
        }
    }
}