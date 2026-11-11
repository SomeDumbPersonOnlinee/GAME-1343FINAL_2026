using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 5f;
    public float Lifetime = 5f;
    public bool FacingTarget = false;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = gameObject.transform.forward * Speed;
    }

    private void OnTriggerEnter (Collider other)
    {
        //This is where the Ricoshet and Hitting target stuff will happen (I think)
    }

    void Update()
    {
        if(FacingTarget)
        {
            StrikeApose();
        }
    }

    public void StrikeApose()
    {
        //This is where you'll strike a pose
    }

    public void DestroyProjectile()
    {
        //This happens when you hit the target
        Destroy(gameObject);
    }
}
