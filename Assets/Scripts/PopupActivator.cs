using UnityEngine;

public class PopupActivator : MonoBehaviour
{
    /// <summary>
    /// probbaly going to consolidate into more useful script in the future!
    /// script that turns something on or off
    /// </summary>
    /// 
    public GameObject popUp;
    public bool isOpen;
    public void SwitchControl()
    {
        if (isOpen == true)
        {
            popUp.SetActive(false);
            isOpen = false;   
        }
        else if (isOpen == false)
        {
            popUp.SetActive(true);
            isOpen = true;
        }
    }

}
