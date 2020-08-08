using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] _List;
    public string playerTurn;
    public GameObject Winner;
    public Text winText;
    public GameObject resetLevel;
    int numOfPlayes;
    int scoreX;
    int scoreO;

    [SerializeField] Text ScoreX;
    [SerializeField] Text ScoreO;
    private void Awake()
    {
        Winner.SetActive(false);
        setManager();
        playerTurn = "X";
        numOfPlayes = 0;
        resetLevel.SetActive(false);
    }
    void setManager()
    {
        for (int i = 0; i < _List.Length; i++)
        {
            _List[i].GetComponentInParent<ButtonInteract>().setGameManager(this);

        }
    }

    public string getTURN()
    {
        return playerTurn;
    }

    public void endTurn()
    {
        numOfPlayes++;

        if(_List[0].text == playerTurn && _List[1].text == playerTurn && _List[2].text == playerTurn)
        {
            gameOver(playerTurn);
        }

        else if(_List[3].text == playerTurn && _List[4].text == playerTurn && _List[5].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if(_List[6].text == playerTurn && _List[7].text == playerTurn && _List[8].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (_List[0].text == playerTurn && _List[3].text == playerTurn && _List[8].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (_List[2].text == playerTurn && _List[3].text == playerTurn && _List[7].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (_List[0].text == playerTurn && _List[4].text == playerTurn && _List[7].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (_List[1].text == playerTurn && _List[3].text == playerTurn && _List[6].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (_List[2].text == playerTurn && _List[5].text == playerTurn && _List[8].text == playerTurn)
        {
            gameOver(playerTurn);
        }
        else if (numOfPlayes == 9)
        {
           gameOver("Draw");
        }
        

        NextPlayerTurn();
    }

    void gameOver(string winningPlayer)
    {
        setInteractable(false);
        if(winningPlayer == "Draw")
        {
            setGameOver("It's a Draw");
        }
        else
        {
            setGameOver( playerTurn + "-->" + "Wins!");
        }

        resetLevel.SetActive(true);
    }
    public void resetGame()
    {
        numOfPlayes = 0;
        Winner.SetActive(false);
        setInteractable(true);
        for (int i = 0; i < _List.Length; i++)
        {
            _List[i].GetComponentInParent<Button>().interactable = true;
            _List[i].text = "";
        }
        resetLevel.SetActive(false);
    }

    void setInteractable(bool tog)
    {
        for (int i = 0; i < _List.Length; i++)
        {
            _List[i].GetComponentInParent<Button>().interactable = tog;
            
        }
    }
    void setGameOver(string value)
    {
        Winner.SetActive(true);
        winText.text = value;
        if(value == "It's a Draw")
        {

        }
        else if (playerTurn == "X")
        {
            scoreX += 1;
            ScoreX.text = scoreX.ToString();
            Debug.Log(" X = " + scoreX);
        }
        else if (playerTurn == "O")
        {
            scoreO += 1;
            ScoreO.text = scoreO.ToString();
            Debug.Log(" O = " + scoreO);
        }
       
    }
    void NextPlayerTurn()
    {
        playerTurn = (playerTurn == "X") ? "O" : "X";
    }
}
