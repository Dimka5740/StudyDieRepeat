using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playng : MonoBehaviour
{
    void Start()
    {
        SwypeController.SwypeEvent += CheckSwype;
    }
    void CheckSwype(SwypeController.SwypeType type)
    {
        print("ОНО РАБОТАЕТ!");
    }
}
