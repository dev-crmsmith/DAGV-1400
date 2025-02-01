using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private static readonly Color[] Colors = { Color.white, Color.blue, Color.green, Color.red, Color.yellow, Color.magenta };

    private bool _isColliding; // Bool to track collision state
    private int _colorIndex; // Index number of the current color
    
    // Start is called before the first frame update
    private void Start()
    {
        ResetColorChange();
    }

    public void ResetColorChange()
    {
        _colorIndex = 0;
        GetComponent<SpriteRenderer>().material.color = Colors[_colorIndex];
        _isColliding = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Testing to make sure that a collision is fully resolved [Enter -> Exit] before
        // the object is capable of switching colors again.
        if (!_isColliding)
        {
            _isColliding = true;
            _colorIndex++;
            if (_colorIndex == Colors.Length)
            {
                _colorIndex = 0;
            }

            GetComponent<SpriteRenderer>().material.color = Colors[_colorIndex];
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _isColliding = false;
    }
}
