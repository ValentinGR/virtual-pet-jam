using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    CameraObj cameraObj;
    Rooms rooms;

    void Awake()
    {
        cameraObj = Camera.main.gameObject.AddComponent<CameraObj>();
        cameraObj.CameraObjConstructor(new Vector3(0, 1, -10), 1);
        rooms = new Rooms();

        FindObjectOfType<InputsEvents>().SetCameraObj(cameraObj);
    }
}
