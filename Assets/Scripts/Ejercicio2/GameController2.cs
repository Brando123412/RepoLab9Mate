using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController2 : MonoBehaviour
{
    [SerializeField]CodigoPlayer1 player1;
    [SerializeField]CodigoPlayer1 player2;
    [SerializeField] TMP_Text textPlayer1;
    [SerializeField] TMP_Text textPlayer2;
    void Update(){
        textPlayer1.text = "X = "+ player1.distancia.ToString("F2");
        textPlayer2.text = "X = "+  player2.distancia.ToString("F2");
    }
}
