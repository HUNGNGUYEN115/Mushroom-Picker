using UnityEngine;

public class MushroomNamePanel : MonoBehaviour
{
    public UIPanelAnimation namePanel; // Reference to the UI panel script
    public IndexSystem indexSystem;
    public void Touch()
    {
       
            namePanel.gameObject.SetActive(true);
            namePanel.OpenPanel();
            Debug.Log("Touch");
            indexSystem.UnlockIndex();
             // Show the mushroom name panel
        
    }
    public void Leave()
    {
        
            
            namePanel.ClosePanel();
            Debug.Log("Leave");
        
    }
}
