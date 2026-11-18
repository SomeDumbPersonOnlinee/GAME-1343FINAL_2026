using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    bool hasShot = false;
    public Transform projectileSpawner;
    public GameObject projectilePrefab;

    bool rotateLeft = false;
    bool rotateRight = false;
    bool shoot = false;



    // Update is called once per frame
    void Update()
    {
        GetInput();
        controling();
    }

    public void controling()
    {
        //This makes the player stop turing after they shoot
        if(hasShot)
        {
            if (rotateLeft || rotateRight)
            {
                Debug.Log("You can't move after you shoot");
            }
        }
        else
        {
            if (rotateLeft)
            {
                RotatePlayer(-1);
            }
            if (rotateRight)
            {
                RotatePlayer(1);
            }
        }
        if(shoot)
        {
            shootProjectile();
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

        //Keybinds
        rotateLeft = kb.aKey.isPressed;
        rotateRight = kb.dKey.isPressed;
        shoot = kb.wKey.wasPressedThisFrame;
    }

    public void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(Time.deltaTime * value * rotationSpeed * Vector2.up);
    }

    public void shootProjectile()
    {
        //disables shooting after you shoot your shot
        Debug.Log("pewpew");
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
}
