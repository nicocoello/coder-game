using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningTree : MonoBehaviour
{
    [SerializeField]private GameObject _tree;

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(_tree.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
