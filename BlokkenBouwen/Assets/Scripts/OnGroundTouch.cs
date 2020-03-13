using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundTouch : MonoBehaviour
{
    Renderer rend;
    public Material Block_Death;
    // Start is called before the first frame update
    void Start()
    {
         
        rend = GetComponent<Renderer>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ground")
        {
            
            EndGame();
            
        }

    }
    

    private void EndGame()
    {
        GameObject camera = GameObject.Find("Main Camera");
        Debug.Log("END");
        SpawnBlock _mainScript = camera.GetComponent<SpawnBlock>();
        //scr_Enemy enemyScript = enemy.GetComponent<scr_Enemy>();
        _mainScript.GameOver = true;
        rend.material = Block_Death;

    }

    
}
