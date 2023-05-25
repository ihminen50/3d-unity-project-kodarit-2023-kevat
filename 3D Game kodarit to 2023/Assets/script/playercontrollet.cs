using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrollet : MonoBehaviour
{ 
    public CharacterController Charactercontroller;
    public int moveSpeed = 5;



    private float mouseVertical = 0;
    private float mouseHorizontal = 0;
    //Start is called before the first frame update
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        mouseHorizontal += Input.GetAxis("Mouse X");
        mouseVertical += Input.GetAxis("Mouse Y");
        Camera.main.transform.localRotation = Quaternion.Euler(mouseHorizontal, mouseVertical,0);
        float forwardMove = Input.GetAxis("Vertical");
        float sideMove = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(sideMove,0,forwardMove);
        Charactercontroller.SimpleMove(direction * Time.deltaTime * moveSpeed);
    }
}    
