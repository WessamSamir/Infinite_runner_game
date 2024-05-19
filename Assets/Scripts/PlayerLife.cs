using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Block"))
        {
            GameOver.gameover = true;
            gameObject.SetActive(false);
        }
    }

}
