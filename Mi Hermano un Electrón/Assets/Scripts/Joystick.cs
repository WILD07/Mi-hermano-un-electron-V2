using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IDropHandler
{

    public Canvas Padre;
    public float radio;
    Vector3 PosInicial;
    private Vector2 Axis;
    // Use this for initialization

    public Vector2 axis
    {
        get
        {
            return Axis;
        }
    }
    public float Horizontal
    {
        get
        {
            return Axis.x;
        }
    }
    public float Vertical
    {
        get
        {
            return Axis.y;
        }
    }
    public bool isMoving
    {
        get
        {
            return Axis != Vector2.zero;
        }
    }
    void Start () {
        PosInicial = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnDrag(PointerEventData point)
    {        
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(Padre.transform as RectTransform, point.position, Padre.worldCamera, out pos);
        Vector2 NewPos = Padre.transform.TransformPoint(pos) - PosInicial;
        NewPos.x = Mathf.Clamp(NewPos.x, -radio, radio);
        NewPos.y = Mathf.Clamp(NewPos.y, -radio, radio);

        Axis = NewPos / radio;

        transform.localPosition = NewPos;
    }
    public void OnDrop(PointerEventData point)
    {
        transform.position = PosInicial;
        Axis = Vector2.zero;
    }
}
