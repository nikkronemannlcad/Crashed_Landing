using UnityEngine;

public class ShipDeposit : MonoBehaviour
{
    /// <summary>
    /// This script manages when a player can deposit ship parts and alters their inventory when it does
    /// It also adds a visual indicator on the ship that it is fixed
    /// It uses the collection bool from the last item pickup to trigger this
    /// </summary>
     
    
    //[SerializeField] private bool thisPartCollected;
    [SerializeField] private bool inShipZone;
    public bool allPiecesCollected;
    [SerializeField] private GameObject depositMessage;

    public PopupActivator pa;

    public GameManager gm;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gm.shipPartsCollected >= 2)
        {
            Debug.Log("canDeposit");
            inShipZone = true;
            depositMessage.SetActive(true);
        } 
        else if (other.gameObject.CompareTag("Player"))
        {
            inShipZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        inShipZone = false;
        depositMessage.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && gm.shipPartsCollected >= 2 && inShipZone)
        {
            Debug.Log("dropped the item");

            //THIS WILL NOT BE HERE FOR FINAL
            //for now bc we only need one ship part for the demo at minimum I am placing the win bool here
            //we are probably going to change what the win bool is but no matter what its going to trigger the win screen
            allPiecesCollected = true;
            pa.isOpen = true;
        }
    }
}
