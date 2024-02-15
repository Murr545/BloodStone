using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    
    public CharacterController PlayerController;
    public float MouseSensitivity = 100f;
    public Transform PlayerBody;
    public Camera MapCamera;
    float xRotation = 0f;
    float Speed = 5f;
    Vector3 Velocity;
    float Gravity = -9.81f;
    
    void Update()
    {   
     //Передвижение героя
     float moveX = Input.GetAxis("Horizontal");
     float moveZ = Input.GetAxis("Vertical");
     
     Vector3 MovePosition = transform.right * moveX + transform.forward * moveZ;
     PlayerController.Move(MovePosition * Speed * Time.deltaTime);
     
     Velocity.y += Gravity * Time.deltaTime;
     
     PlayerController.Move(Velocity * Time.deltaTime);
     
     //Приближение отдаление камеры
      if (Input.GetAxis("Mouse ScrollWheel") > 0f && MapCamera.fieldOfView >= 25) // forward
      {
        //доработать приближение, проблема: камера приближается с силой кручения колесика, поэтому иногда выходит за рамки значения 60
        MapCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * 10;
      }
      else if (Input.GetAxis("Mouse ScrollWheel") < 0f && MapCamera.fieldOfView < 60) // backwards
      {
        MapCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * 10;
      }
    }
}
