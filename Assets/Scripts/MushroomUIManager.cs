using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MushroomUIManager : MonoBehaviour
{
    public MushroomData mushroom;
    public TextMeshProUGUI mushroomName;
    public TextMeshProUGUI mushroomInfo;
    public TextMeshProUGUI mushroomInfoName;
    public TextMeshProUGUI mushroomType;
    public Image mushroomImage;

    public UIPanelAnimation namePanel;
    public IndexSystem indexSystem;
    public static MushroomUIManager currentHoveredMushroom;

    private bool isGrabbed = false;

    public void Touch()
    {
        mushroomInfo.text = mushroom.mushroominfor;
        mushroomInfoName.text = mushroom.mushroomname;
        mushroomType.text = "Type: " + mushroom.mushroomtype.ToString();
        if (mushroom.mushroomtype == Type.Edible)
        {
            mushroomType.color = Color.green;

        }
        else
        {
            mushroomType.color = Color.red;
        }
    }

    public void OnHoverEnter(HoverEnterEventArgs args)
    {
        if (!isGrabbed) // Only show the panel if not grabbed
        {
            currentHoveredMushroom = this;
            namePanel.gameObject.SetActive(true);
            
            namePanel.OpenPanel();
            mushroomName.text = mushroom.mushroomname;
            Debug.Log("Hover Enter");
        }
    }

    public void OnHoverExit(HoverExitEventArgs args)
    {
        if (!isGrabbed) // Only close if not grabbed
        {
            namePanel.ClosePanel();
            Debug.Log("Hover Exit");
            currentHoveredMushroom = null;
        }
    }

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        isGrabbed = true;
        namePanel.gameObject.SetActive(true);
        indexSystem.UnlockIndex();
        namePanel.OpenPanel();
        mushroomName.text = mushroom.mushroomname;
        Debug.Log("Grabbed");
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        isGrabbed = false;
        namePanel.ClosePanel();
        Debug.Log("Released");
        currentHoveredMushroom = null;
    }
}
