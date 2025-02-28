using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupScript : MonoBehaviour
{
    public Color goodColor;
    public Color poisonColor;
    public Color HalucinogenicColor;
    // Start is called before the first frame update
    void Start(){
        
    }

    void OnTriggerEnter(Collider other){
        MushroomUIManager othUI=other.gameObject.transform.parent.gameObject.GetComponent<MushroomUIManager>();
        if(othUI == null){
            Debug.Log("No Mushroom");
            Debug.Log(other.gameObject.name);
            return;
        }
        MushroomData data = othUI.mushroom;

        if(data.mushroomtype == Type.Poisonous){
            Debug.Log("Poisonous");
            GetComponent<SpriteRenderer>().color = poisonColor;
        }else{
            Debug.Log("Edible");
            GetComponent<SpriteRenderer>().color = goodColor;
        }
        Destroy(other.gameObject.transform.parent.gameObject);

    }
}
