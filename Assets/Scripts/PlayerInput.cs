using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public StaminaManager staminaManager;
    public AmmoDisplay ammoDisplay;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            staminaManager.UseStamina(10);

        if (Input.GetKeyDown(KeyCode.R))
            staminaManager.RegainStamina(5);

        if (Input.GetKeyDown(KeyCode.Mouse0)) // Fire
            ammoDisplay.Fire();

        if (Input.GetKeyDown(KeyCode.E)) // Reload
            ammoDisplay.Reload();
    }
}