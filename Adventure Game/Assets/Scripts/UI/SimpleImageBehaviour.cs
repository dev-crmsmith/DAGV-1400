using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    
    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    public void UpdateWithFloatData()
    {
        // Update the image fill amount based on the float data value
        if (dataObj != null)
        {
            imageObj.fillAmount = dataObj.value;
        }
    }
}
