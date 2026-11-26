using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject Bullet;
    public AudioSource gunFire;
    public AudioSource gunReload;

    public int magSize = 7;
    private int currAmmo = 0;

    public float reloadSpeed = 10f;
    private float reloadTimer = 0f;

    void Start()
    {
        currAmmo = magSize;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {;
            if (currAmmo > 0)
            {
                Instantiate(Bullet, transform.position, transform.rotation);
                currAmmo--;
                reloadTimer = 0f;
                Debug.Log("Ammo: " + currAmmo);
                gunFire.pitch = Random.Range(0.7f, 1.4f);
                gunFire.Play();
            }
        } 

        if (currAmmo < magSize)
        {
            if (!Input.GetKey(KeyCode.Mouse0))
            {
                reloadTimer += Time.deltaTime;
                if (reloadTimer >= reloadSpeed)
                {
                    currAmmo++;
                    reloadTimer = 0f;
                    gunReload.Play();
                    gunReload.pitch = Random.Range(0.85f, 1.15f);
                    Debug.Log("ammo regened " + currAmmo);
                }
            }
            else
            {
                reloadTimer = 0f;
            }
        }
    }
}