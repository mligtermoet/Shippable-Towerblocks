using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBlock : MonoBehaviour
{
    public GameObject block;
    public Text text;
    public bool GameOver = false;
    private float score = 0;

    private CameraFollow _cameraFollow;
    public GameObject GameOverText;
    public GameObject Panel;
    public GameObject restartButton;

    void Start()
    {
        _cameraFollow = Camera.main.GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    public void ResetGame()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction*100, Color.green);
        
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawnpos = hit.point;
            spawnpos.z = 0;
            if (Input.GetKeyDown(KeyCode.Mouse0) == true)
            {
                if (GameOver == false)
                {
                    score += 1;
                    
                    _cameraFollow.newY += 1;
                    text.text = "Score: " + score;
                    Instantiate(block, spawnpos, Quaternion.identity);
                }
            }
        }

        if (GameOver == true)
        {
            Panel.SetActive(true);
            GameOverText.SetActive(true);
            _cameraFollow.newY = 3;
            restartButton.SetActive(true);

        }

        
    }
}

