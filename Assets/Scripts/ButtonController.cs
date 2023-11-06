using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public Button myButton;
    public Image myImage;
    public TextMeshProUGUI myText;

    void Start()
    {
        myImage.gameObject.SetActive(false);
        myText.gameObject.SetActive(false);

        myButton.onClick.AddListener(ActivateImageAndText);

    }

    public void ActivateImageAndText()
    {
        myImage.gameObject.SetActive(true);
        myText.gameObject.SetActive(true);

        Invoke("DeactivateImageAndText", 1f);
    }

    void DeactivateImageAndText()
    {
        
        myImage.gameObject.SetActive(false);
        myText.gameObject.SetActive(false);
    }
}
