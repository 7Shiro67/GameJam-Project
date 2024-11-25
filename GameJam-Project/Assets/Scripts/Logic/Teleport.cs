using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetPosition1;
    public GameObject targetPosition2;
    public GameObject playerPosition;
    
    public void teleport()
    {
        if (playerPosition.transform.position.y > -5)
        {
            playerPosition.transform.position = targetPosition2.transform.position;
        }
        
        else
        {
            playerPosition.transform.position = targetPosition1.transform.position;
        }
    }
}
