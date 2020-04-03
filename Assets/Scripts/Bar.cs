using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
public class Bar : MonoBehaviour
{

    public GameObject timeUpMessage;
    public GameObject bar;
    public int time;
    public GameObject WinningButton;
    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(ShowMessage);
    }

    public void ShowMessage()
    {
        timeUpMessage.SetActive(true);
        WinningButton.SetActive(true);
    }
}
