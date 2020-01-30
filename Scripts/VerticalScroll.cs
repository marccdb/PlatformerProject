using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour
{

    [SerializeField] float scrollSpeed;





    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.up * scrollSpeed * Time.deltaTime);


    }
}
