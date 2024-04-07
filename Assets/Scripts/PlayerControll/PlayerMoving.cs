using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerConroll
{
    public class PlayerMoving : MonoBehaviour
    {
        private float minX = -5f; 
        private float maxX = 5f;
        private float smoothTime = 0.01f;

        private bool isDragging = false; 
        private Vector3 dragStartPosition;
        private Vector3 velocity = Vector3.zero;

        void Update()
        {
            if (Input.touchCount > 0) 
            {
                Touch touch = Input.GetTouch(0); 

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position); 
                        if (GetComponent<Collider2D>().OverlapPoint(touchPosition)) 
                        {
                            isDragging = true;
                            dragStartPosition = touchPosition;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (isDragging)
                        {
                            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(touch.position); 
                            float deltaX = currentPosition.x - dragStartPosition.x; 
                            float targetX = Mathf.Clamp(transform.position.x + deltaX, minX, maxX); 
                            Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z); 
                            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime); 
                            dragStartPosition = currentPosition;
                        }
                        break;

                    case TouchPhase.Ended:
                        isDragging = false;
                        break;
                }
            }
        }
    }
}
