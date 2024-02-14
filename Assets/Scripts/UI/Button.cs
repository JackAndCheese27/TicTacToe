using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    private DetectCursor detectCursor;
    [SerializeField] private UnityEvent FunctionOnClick;
    
    void Start()
    {
        detectCursor = GetComponent<DetectCursor>();
    }

    
    void Update()
    {
        if (detectCursor.MouseDetected)
        {
            if (Input.GetMouseButtonDown(0))
            {
                FunctionOnClick.Invoke();
            }
        }
    }
}
