using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        List<string> DeathText = new List<string>();
        DeathText.Add("I can't believe the developer of this game is still alive. They must have some kind of death wish.");
        DeathText.Add("I'm not sure if the developer was trying to make a good game or just torture players for their own entertainment");
        DeathText.Add("I'm not sure what the developer was thinking when they made this game, but I'm pretty sure it wasn't with the players in mind.");
        DeathText.Add("I have a feeling the developers were just trying to torture players with this one.");
        DeathText.Add("I have a feeling the developers just wanted to see how much misery they could cause with this game");
        DeathText.Add("Well, at least you don't have to suffer through this game anymore");
        DeathText.Add("I guess you won't have to worry about getting any better at this game now");
        DeathText.Add("At least you won't have to endure any more of this torture");
        DeathText.Add("I hope you find peace in the great beyond, because you certainly didn't find it in this game.");
        DeathText.Add("I guess you dont have to find out how boredom can kill you");
        DeathText.Add("Well, at least you won't have to worry about winning or losing anymore. Death is the ultimate victory");
        DeathText.Add("Dead? Don't worry, the rest of your life will probably be just as disappointing");
        DeathText.Add("Did the game made you feel like complete failure ? It's important to have those moments of self-doubt and inadequacy in a video game.");


        string DeathMess = DeathText[Random.Range(0, DeathText.Count)];
        text.text = DeathMess;
    }

}
