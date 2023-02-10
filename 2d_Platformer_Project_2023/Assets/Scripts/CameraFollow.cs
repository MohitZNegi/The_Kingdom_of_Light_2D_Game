using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

 
    //Follow player

   [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float aboveDistance;
  
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    private float lookAbove;
   

    private void Update()
    {
      

        //Follow player
        transform.position = new Vector3(player.position.x + lookAhead, player.position.y + lookAbove, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
        lookAbove = Mathf.Lerp(lookAbove, (aboveDistance * player.localScale.y), Time.deltaTime * cameraSpeed);
    }



}
