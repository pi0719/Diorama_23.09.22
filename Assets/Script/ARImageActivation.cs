using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ARImageActivation : MonoBehaviour
{
    [SerializeField]
    private ARTrackedImageManager trackedImageManager;

    [SerializeField]
    private GameObject activationCanvas; // 여기서 Canvas 연결

    [SerializeField]
    private Image[] activationImages; // 이미지 배열

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            UpdateActivationImage(trackedImage);
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            UpdateActivationImage(trackedImage);
        }
    }

    private void UpdateActivationImage(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;

        // 이미지가 인식되었습니다 디버그 로그 추가
        Debug.Log("이미지가 인식되었습니다: " + imageName);

        // Canvas 활성화
        activationCanvas.SetActive(true);

        // 모든 이미지를 먼저 비활성화
        foreach (var image in activationImages)
        {
            image.gameObject.SetActive(false);
        }

        // 특정 이미지를 활성화
        if (imageName == "AImageName") // 이 이름은 실제 이미지 이름에 맞게 변경해주세요.
        {
            activationImages[0].gameObject.SetActive(true);
        }
        // 다른 이미지들에 대해서도 비슷한 방식으로 설정 가능
    }
}
