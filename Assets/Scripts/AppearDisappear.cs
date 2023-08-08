using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappear : MonoBehaviour
{
    public GameObject assetToToggle;

    private bool isGameRunning = true;

    void Start()
    {
        StartCoroutine(ShowAndHideAsset());
    }

    IEnumerator ShowAndHideAsset()
    {
        while (isGameRunning)
        {
            ShowAsset();
            yield return new WaitForSeconds(2f);
            HideAsset();
            yield return new WaitForSeconds(1.5f);
        }
    }

    public void ShowAsset()
    {
        assetToToggle.SetActive(true);
    }

    public void HideAsset()
    {
        assetToToggle.SetActive(false);
    }

    // Call this method when the game is over
    public void GameOver()
    {
        isGameRunning = false;
    }
}
