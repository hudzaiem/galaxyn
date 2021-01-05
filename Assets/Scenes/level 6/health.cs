using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int Health;
    public int numHeart;

    public Image[] heart;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void update(){
        if (Health > numHeart){
            Health = numHeart;
        }

        for (int i = 0; i < heart.Length; i++)
        {
            if(i < Health){
                heart[i].sprite = fullHeart;
            }
            else
            {
                heart[i].sprite = emptyHeart;
            }

            if (i < numHeart){
                heart[i].enabled = true;
            }
            else
            {
                heart[i].enabled = false;
            }
        }
    }
}
