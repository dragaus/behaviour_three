using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class MyCube : MonoBehaviour
{
    [Task]
    void SetColor(float red, float green, float blue)
    {
        GetComponent<MeshRenderer>().material.color = new Color(red, green, blue);
        Task.current.Succeed();
    }

    [Task]
    void SetRed()
    {
        GetComponent<MeshRenderer>().material.color = new Color(1f, 0f, 0f);
        Task.current.Succeed();
    }

    [Task]
    void SetBlue()
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 1f);
        Task.current.Succeed();
    }

    [Task]
    void SetGreen()
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 0f);
        Task.current.Succeed();
    }
}
