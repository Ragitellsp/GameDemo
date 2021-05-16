﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;
    public GameObject transition;
    public Text totalFruits;
    public Text FruitsCollected;
    private int totalFruitsInLevel;
    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }
    private void Update()
    {

        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        FruitsCollected.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount==1)
        {
            Debug.Log("No,Victoria");
            levelCleared.gameObject.SetActive(true);
          
            Invoke("ChangeSence",1);
           
        }
    }
    void ChangeSence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    
}
