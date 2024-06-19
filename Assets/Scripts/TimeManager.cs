using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{


    public float TimeRemaining;

    public TextMeshProUGUI timeText;

    //public GameObject PlayerUI;

    public GameObject GameOverUI;


    public GameObject Camera;

    private Animator animCam;

    public GameObject player;

    private Animator animPlayer;

    public GameObject bgmPlay;

    public GameObject bgmGameOver;

    private void Awake()
    {
        animCam = Camera.GetComponent<Animator>();
        animPlayer = Camera.GetComponent<Animator>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        bgmGameOver.SetActive(false);
        bgmPlay.SetActive(true);
        //PlayerUI.SetActive(true);
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(TimeRemaining >= 0)
        {
            

            TimeRemaining -= Time.deltaTime;

            
            

            timeText.text = "Time : " + TimeRemaining.ToString();
        }
        else
        {
            if(TimeRemaining < 0)
            {
                TimeRemaining = 0;
            }
            bgmPlay.SetActive(false);
            bgmGameOver.SetActive(true);
            timeText.text = "Time : " + TimeRemaining.ToString();
            animCam.SetInteger("state", 4);
            //animPlayer.SetInteger("state", 4);
            GameOverUI.SetActive(true);
        }



    }
}
