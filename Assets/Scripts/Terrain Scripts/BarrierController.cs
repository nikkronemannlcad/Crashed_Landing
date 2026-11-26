using UnityEngine;

public class BarrierController : MonoBehaviour
{
    [SerializeField] private GameObject secretPath;
    [SerializeField] private GameObject gogglesUI;
    [SerializeField] private bool gogglesEquip;

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Q)) && gogglesEquip == true) //check if they're on to take them off
        {
            Debug.Log("goggles off");
            gogglesEquip = false;
            gogglesUI.SetActive(false);
            
            secretPath.SetActive(true);
        } 
        else if ((Input.GetKeyDown(KeyCode.Q)) && gogglesEquip == false) //check if they're off to put them on
        {
            Debug.Log("goggles on");
            gogglesEquip = true;
            gogglesUI.SetActive(true);
            
            secretPath.SetActive(false);
        }
    }

}
