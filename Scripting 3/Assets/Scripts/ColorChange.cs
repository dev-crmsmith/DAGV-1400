using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private static readonly Color[] Colors = { Color.white, Color.blue, Color.green, Color.red, Color.yellow, Color.magenta };

    private bool _isColliding;
    private int _colorIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        _colorIndex = 0;
        GetComponent<SpriteRenderer>().material.color = Colors[_colorIndex];
        _isColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
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
