using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPicking : MonoBehaviour
{
    private int points;
   

    private void Update()
    {
        if (points == 25)
        {
            Debug.Log("¡YOU HAVE FEW POINTS LEFT TO WIN! You have 25 points!");
            
        }
        else if(points == 30)
        {
            Debug.Log("¡YOU WIN! You have 30 points!");  //when all the flowers are collected, the player wins
            Time.timeScale = 0; //time stops when all the collectables are collected
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("flower"))  //when the player collects a flower, these one dissapear
        {
            Destroy(other.gameObject); //the collectable dissapear 
            points++;   //when  a flower is collected, the player earns points
            Debug.Log("Congratulations, you have received picked a flower!");
           
        }
        else if (other.gameObject.name.Contains("FantasyBee"))  //when the player collects a bee, these one dissapear
        {
            Destroy(other.gameObject);
            points++;
            Debug.Log("Congratulations, you have received picked a bee!");
        }
    }
}
    
