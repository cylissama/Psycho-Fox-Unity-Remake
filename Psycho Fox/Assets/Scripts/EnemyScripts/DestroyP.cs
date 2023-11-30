using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyP : MonoBehaviour
{
    public GameObject bro;

    public void Destroy() {
        Destroy(bro);
    }
}
