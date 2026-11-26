using UnityEngine;

public class WarpZone : MonoBehaviour
{   
    /// <summary>
    /// Made to trigger game manager's load level script once this area is entered
    /// </summary>
    
    public GameManager gm;
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.LoadLevel1();
        }
    }
}
