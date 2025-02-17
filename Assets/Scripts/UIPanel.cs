using UnityEngine;

public class UIPanelAnimation : MonoBehaviour
{
    private bool isOpen = true;
    public float animationDuration = 0.5f;

    void Start()
    {
        transform.localScale = new Vector3(0, 1, 1); // Start hidden
    }

    public void TogglePanel()
    {
        if (isOpen)
        {
            gameObject.SetActive(true);
            OpenPanel();
        }
        else
        {
            
            ClosePanel();
        }
        isOpen = !isOpen;
    }

    public void OpenPanel()
    {
        LeanTween.scaleX(gameObject, 1, animationDuration).setEase(LeanTweenType.easeOutQuad);
    }

    public void ClosePanel()
    {
        LeanTween.scaleX(gameObject, 0, animationDuration).setEase(LeanTweenType.easeInQuad).setOnComplete(() => gameObject.SetActive(false));
    }
}
