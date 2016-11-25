using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    [SerializeField]
    private Transform startPos;
    [SerializeField]
    private Transform endPos;
    [SerializeField]
    private Transform bird;
    
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = bird.position.x;
        newPosition.x = Mathf.Clamp(newPosition.x, startPos.position.x, endPos.position.x);
        transform.position = newPosition;
    }
}
