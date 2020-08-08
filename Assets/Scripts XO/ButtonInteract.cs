using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteract : MonoBehaviour
{
    private GameManager manager;
    [SerializeField] private Button _button;
    [SerializeField] private Text _text;
    int scoreX;
    int scoreO;

    public void Turn()
    {
        _text.text = manager.getTURN();
        _button.interactable = false;
        manager.endTurn();
    }
    public void setGameManager(GameManager mang)
    {
        manager = mang;
    }
   
}
