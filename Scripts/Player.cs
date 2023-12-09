using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Target;
    Vector3 mousePos, worldPos;
    float posy;
    // Start is called before the first frame update
    void Start()
    {
        posy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        //É}ÉEÉXí«è]
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        transform.position = worldPos;

        //à⁄ìÆîÕàÕêßå¿
        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -1.9f, 3.3f);
        currentPos.y = Mathf.Clamp(currentPos.y, posy, posy);
        transform.position = currentPos;
    }
}
