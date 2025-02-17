using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class IndexSystem : MonoBehaviour
{

    // Start is called before the first frame update
    public Button Button;
    public MushroomUIManager UIUIManager;
    public TextMeshProUGUI mushroomName;
    public Image mushroomImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UnlockIndex()
    {
        Button.interactable = true;
        mushroomImage.sprite= UIUIManager.mushroom.image;
        mushroomName.text = UIUIManager.mushroom.name;
    }
}
