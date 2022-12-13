using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPicking : MonoBehaviour
{
    public int points;
    public int totalPoints;

    private void Update()
    {
        if (points == 25)
        {
            Debug.Log("¡YOU HAVE FEW POINTS LEFT TO WIN!");
            
        }
        else if(points == 30)
        {
            Debug.Log("¡YOU WIN!");  //when all the flowers are collected, the player wins
            Time.timeScale = 0; //time stops when all the collectables are collected
        }
        
    }

  
    private int InitialPoints(int newPoints)
    {
       int result = totalPoints += newPoints;
        return result;//earn points
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("flower"))  //when the player collects a flower, these one dissapear
        {
            Destroy(other.gameObject);
            points++;   //when  a flower is collected, the player earns points
            
        }else if (other.gameObject.name.Contains("FantasyBee"))  //when the player collects a bee, these one dissapear
        {
            Destroy(other.gameObject);
            points++;
        }
    }
}
    
