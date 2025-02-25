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
    public Image mushroomImage; // Assign an image in the Inspector

    public UIPanelAnimation namePanel; // Reference to the UI panel script
    public IndexSystem indexSystem;
    public static MushroomUIManager currentHoveredMushroom;

    //public  GameObject infoPanel;
    public void Update()
    {
        //mushroomName.text = mushroom.mushroomname;



        // Optional: Set an image if the mushroom has one
        // mushroomImage.sprite = mushroom.mushroomIcon;
    }

    public void Touch()
    {

        //    namePanel.gameObject.SetActive(true);
        //    namePanel.OpenPanel();
        //    Debug.Log("Touch");
        //    indexSystem.UnlockIndex();
        //    // Show the mushroom name panel

        mushroomInfo.text = mushroom.mushroominfor;
        mushroomInfoName.text = mushroom.mushroomname;
        mushroomType.text = "Type: " + mushroom.mushroomtype.ToString();

    }
    public void OnHoverEnter(HoverEnterEventArgs args)
    {
        currentHoveredMushroom = this;
        namePanel.gameObject.SetActive(true);
        indexSystem.UnlockIndex();
        namePanel.OpenPanel();
        Debug.Log("Touch");
        mushroomName.text = mushroom.mushroomname;

    }

    //    public void Leave()
    //{




    //}
    public void OnHoverExit(HoverExitEventArgs args)
    {
        namePanel.ClosePanel();
        Debug.Log("Leave");
        // Reset current hovered mushroom
        currentHoveredMushroom = null;
    }

}