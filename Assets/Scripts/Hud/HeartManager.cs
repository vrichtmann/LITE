﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] private GameObject[] correctManagers;
    public PlayerMove playerMove;
    public Sprite deadSprite;

    public void updateLife(int _currentLife){
        for(int i = 0; i < correctManagers.Length; i++){
            if(i < _currentLife){
                correctManagers[i].SetActive(true);
            } else{
                correctManagers[i].GetComponent<Image>().sprite = deadSprite;
                //correctManagers[i].SetActive(false);
            }
        }

        if(_currentLife <= 0)   {
            playerMove.die();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
