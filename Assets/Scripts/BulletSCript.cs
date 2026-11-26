using Unity.Mathematics;
using UnityEngine;

public class BulletSCript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject enemy;
    public AudioClip enemyDeath;

 
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 20f, ForceMode.Impulse);
    }

    private void Update()
    {
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            enemy = other.gameObject;

            AudioSource.PlayClipAtPoint(enemyDeath, enemy.transform.position);

            Destroy(enemy);
            Destroy(gameObject);

        }
    }
}

