using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour

{
    //[SerializedField]float xValue = 0.01f;
    //[SerializedField]float yValue = 0;
    //[SerializedField]float zValue = 0;

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    //transform.Translate(xValue, yValue, zValue);

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
