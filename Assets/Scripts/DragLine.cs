using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLine : MonoBehaviour
{
    LineRenderer _lineRender;
    Bird _bird;

    // Start is called before the first frame update
    void Start()
    {
        _lineRender = GetComponent<LineRenderer>();
        _bird = FindObjectOfType<Bird>();

        Vector3 lineZeroPostion = new Vector3(
            _bird.transform.position.x,
            _bird.transform.position.y,
            -0.1f);
        _lineRender.SetPosition(0,lineZeroPostion);
    }

    // Update is called once per frame
    void Update()
    {
        if (_bird.IsDragging)
        {
            _lineRender.enabled = true;
            _lineRender.SetPosition(1,_bird.transform.position);
        }
        else
        {
            _lineRender.enabled = false;
        }
       
    }
}
