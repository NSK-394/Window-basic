using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public CanvasGroup menuUI;
    public MouseFollow player;

    public void StartGame()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float duration = 1f;
        float time = 0;

        while (time < duration)
        {
            menuUI.alpha = 1 - (time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        menuUI.alpha = 0;
        menuUI.interactable = false;
        menuUI.blocksRaycasts = false;

        player.canMove = true;
    }
}