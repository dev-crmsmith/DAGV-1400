using UnityEngine;

public class SimpleHunger : MonoBehaviour
{

    public SimpleFloatData healthData; // Reference to the health data
    public SimpleFloatData hungerData; // Reference to the hunger level data
    
    public SimpleImageBehaviour healthImageBehaviour; // Reference to the health image behaviour
    public SimpleImageBehaviour hungerImageBehaviour; // Reference to the hunger image behaviour
    
    public float tickRate = 1f; // How often to update the hunger level (in seconds)
    private float timer = 0f; // Timer to track the time since the last update
    // Start is called before the first frame update
    void Start()
    {
        hungerData.SetValue(1); // Initialize hunger level to 1 (full)
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        while (timer >= tickRate)
        {
            timer -= tickRate;
            // Decrease hunger level and clamp it to a minimum of 0
            hungerData.value -= 0.01f;
            hungerData.value = Mathf.Clamp(hungerData.value, 0, 1);
            // Decrease health if hunger is at 0
            if (hungerData.value == 0)
            {
                healthData.value -= 0.01f;
                healthData.value = Mathf.Clamp(healthData.value, 0, 1);
            }
            
            // Update the UI
            healthImageBehaviour.UpdateWithFloatData();
            hungerImageBehaviour.UpdateWithFloatData();
        }
    }
}
