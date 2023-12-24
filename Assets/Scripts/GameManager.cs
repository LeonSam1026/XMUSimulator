using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    public GameObject m_WholePanel;
    public GameObject m_NextPanel;
    public Animator m_NextPanelAnimator;
    public Animator m_AchiveAnimator;
    public TextMeshProUGUI m_Text;
    public TextMeshProUGUI achieve_Text;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;

        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
        if(_playerScore-_computerScore >= 3)
        {
            this.playerPaddle.ResetPosition();
            this.computerPaddle.ResetPosition();
            this.ball.ResetPosition();
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // 播放 Show 动画
            m_Text.text = "The competition is over! You win! ";
            achieve_Text.text = "Ping-pong winner";
            m_AchiveAnimator.Play("Achive_show"); // 播放 Show 动画
        }
        else if (_computerScore - _playerScore >= 3)
        {
            this.playerPaddle.ResetPosition();
            this.computerPaddle.ResetPosition();
            this.ball.ResetPosition();
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // 播放 Show 动画
            m_Text.text = "The competition is over! You lose! ";
        }
    }

    public void ComputerScores()
    {
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
        if (_playerScore - _computerScore >= 3)
        {
            this.playerPaddle.ResetPosition();
            this.computerPaddle.ResetPosition();
            this.ball.ResetPosition();
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // 播放 Show 动画
            m_Text.text = "The competition is over! You win! ";
            achieve_Text.text = "Ping-pong winner";
            m_AchiveAnimator.Play("Achive_show"); // 播放 Show 动画
        }
        else if (_computerScore - _playerScore >= 3)
        {
            this.playerPaddle.ResetPosition();
            this.computerPaddle.ResetPosition();
            this.ball.ResetPosition();
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // 播放 Show 动画
            m_Text.text = "The competition is over! You lose! ";
        }
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
