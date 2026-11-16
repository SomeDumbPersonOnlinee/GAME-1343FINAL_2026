using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    bool hasShot = false;
    bool canPose = false;
    public Transform projectileSpawner;
    public GameObject projectilePrefab;

    bool rotateLeft = false;
    bool rotateRight = false;
    bool shoot = false;
    bool pause = false;
    bool pose = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        controling();
    }

    public void controling()
    {
        if(rotateLeft)
        {
            RotatePlayer(-1);
        }
        if (rotateRight)
        {
            RotatePlayer(1);
        }
        if(shoot)
        {

        }
        if(pause)
        {

        }
        if(pose)
        {

        }
    }
    public void GetInput()
    {
        Keyboard kb = Keyboard.current;

        if(kb == null)
        {
            Debug.LogWarning("Keyboard not working");
            return;
        }
        //Important Keybinds
        // A,D,W,P,T

        rotateLeft = kb.aKey.wasPressedThisFrame;
        rotateRight = kb.dKey.wasPressedThisFrame;
        shoot = kb.wKey.wasPressedThisFrame;
        pause = kb.pKey.wasPressedThisFrame;
        pose = kb.tKey.wasPressedThisFrame;
    }

    public void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(Time.deltaTime * value * rotationSpeed * Vector2.up);
    }

    public void shootProjectile()
    {
        if(hasShot == false)
        {
            GameObject newProjectile = Instantiate(projectilePrefab, projectileSpawner.transform.position, projectileSpawner.transform.rotation);
            hasShot = true;
        }
        else
        {
            Debug.Log("You have already fired your shot!");
        }
    }

    public void strikeApose()
    {
        if(canPose)
        {

        }
    }

}
