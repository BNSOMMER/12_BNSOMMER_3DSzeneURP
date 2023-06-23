using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnClick : MonoBehaviour
{
    public new Animation animation;

    private void Start()
    {
        
        animation = GetComponent<Animation>();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                animation.Play();
            }
        }            
    }
    public void SpawnObjects()
    {
        Debug.Log("Animation startet");

    }
}


