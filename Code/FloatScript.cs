using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatScript : MonoBehaviour
{
    private Vector3 floatVector;
    private float floatSpeed;
    private float time;
    private void Awake()
    {
        floatSpeed = 0.25f;
        time = 0.7f;
        StartCoroutine("Float", time);
    }
    private void Update()
    {
        transform.position += floatVector * Time.deltaTime * floatSpeed;
    }
    private IEnumerator Float(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        floatVector = Vector2.up;
        yield return new WaitForSecondsRealtime(time);
        floatVector = Vector2.down;
        StartCoroutine("Float", time);
    }
}
