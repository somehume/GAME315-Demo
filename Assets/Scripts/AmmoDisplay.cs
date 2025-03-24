using UnityEngine;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    [SerializeField] private int maxAmmo = 30;
    private int currentAmmo;

    [SerializeField] private TextMeshProUGUI ammoText;

    void Start()
    {
        currentAmmo = maxAmmo;
        UpdateUI();
    }

    public void Fire()
    {
        if (currentAmmo > 0)
        {
            currentAmmo--;
            UpdateUI();
        }
    }

    public void Reload()
    {
        currentAmmo = maxAmmo;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (ammoText != null)
            ammoText.text = $"Ammo: {currentAmmo} / {maxAmmo}";
    }
}