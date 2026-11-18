using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{
    public int Speed = 5;
    public bool FacingTarget = false;
    public GameObject gameTarget;

    public int combos = 0;

    public int TotalPoints = 0;
    public int MaxCombo = 0;
    public int MaxSpeed = 0;

    bool pose = false;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = gameObject.transform.forward * Speed;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        //This is where the Ricoshet and Hitting target stuff will happen (I think)

        if (other == gameTarget)
        {
            //Target has been hit
            DestroyProjectile();
        }
    }

    void Update()
    {
        GetInput();
        if (FacingTarget)
        {
            if (pose)
            {
                StrikeApose();
            }
        }
        updateGMValues();
    }

    public void GetInput()
    {
        Keyboard kb = Keyboard.current;

        pose = kb.spaceKey.wasPressedThisFrame;
    }

    public void updateGMValues()
    {
        GameManager.instance.getProjectileValues(TotalPoints, MaxCombo, MaxSpeed, 
                                                 Speed, combos);
    }

    public void StrikeApose()
    {
        Debug.Log("Posed. Score should be = " + TotalPoints);
        TotalPoints += 10;
    }

    public void comparers()
    {
        if(MaxCombo < combos)
        {
            MaxCombo = combos;
        }
        if(MaxSpeed < Speed)
        {
            MaxSpeed = Speed;
        }
    }

    public void DestroyProjectile()
    {
        if(gameTarget)
        {
            Destroy(gameObject);
        }
    }
}
