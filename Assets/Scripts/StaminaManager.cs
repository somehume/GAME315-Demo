using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    [SerializeField] private int maxStamina = 100;
    private int currentStamina;

    [SerializeField] private Slider staminaBar;

    void Start()
    {
        currentStamina = maxStamina;
        UpdateUI();
    }

    public void UseStamina(int amount)
    {
        currentStamina -= amount;
        currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        UpdateUI();
    }

    public void RegainStamina(int amount)
    {
        currentStamina += amount;
        currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (staminaBar != null)
            staminaBar.value = (float)currentStamina / maxStamina;
    }
}