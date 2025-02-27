using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Convai.Scripts.Runtime.Features;
using UnityEngine.XR.Interaction.Toolkit;

public class HandInfo : MonoBehaviour
{
    [SerializeField] private DynamicInfoController _dynamicInfoController;
    [SerializeField] private string _name;

    // Start is called before the first frame update
    void Start()
    {
        _dynamicInfoController.SetDynamicInfo("I am currently holding nothing in my "+ _name + " hand.");
        print("I am currently holding nothing in my "+ _name + " hand.");
    }

    void HoldUpdate(){

    }

    public void newHolding()
    {
        RaycastHit raycastHit;
        if (GetComponent<XRRayInteractor>().TryGetCurrent3DRaycastHit(out raycastHit)){
            Transform t = raycastHit.collider.gameObject.transform.parent;
            GameObject obj;
            if (t != null){
                obj = t.gameObject;
            }else{
                obj = null;
            }
            MushroomUIManager mui;
            if (obj != null){
                mui = obj.GetComponent<MushroomUIManager>();
            }else{
                mui = null;
            }
            if (mui != null){
                _dynamicInfoController.SetDynamicInfo("I am currently holding " + mui.mushroom.mushroomname + " in my "+ _name + " hand.");
                print("I am currently holding " + obj.name + " in my "+ _name + " hand.");
                return;
            }
        }
        _dynamicInfoController.SetDynamicInfo("I am currently holding nothing in my "+ _name + " hand.");
        print("I am currently holding nothing in my "+ _name + " hand.");
    }

}
