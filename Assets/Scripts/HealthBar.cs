using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    EnemyStats enemyStats;

    public Slider slider; // Reference to the health slider UI element

    // Adjust the maximum health as needed
    public float maxHealth = 50f;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemyStats = GetComponent<EnemyStats>();

        // Ensure the healthSlider is assigned in the Inspector or find it in the hierarchy
        if  (slider == null)
        {
            slider = GetComponentInChildren<Slider>();
        }

        // Set the maximum value of the health slider
        slider.maxValue = enemyStats.health;
        UpdateHealthBar();
    }

    // Method to update the health bar
    public void UpdateHealthBar()
    {
        // Calculate the health percentage

        // Update the fill amount of the health slider
        slider.value = enemyStats.health;
    }
}
