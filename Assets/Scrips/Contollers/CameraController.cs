using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        Vector3 dir = Player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x, dir.y, 0.0f);
        this.transform.Translate(moveVector);
    }
}
