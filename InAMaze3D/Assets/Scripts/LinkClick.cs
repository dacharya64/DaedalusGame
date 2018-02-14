using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinkClick : MonoBehaviour {
    public Canvas TwineTextPlayer;

    private Button btn;

    // Use this for initialization
    void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick() {
        if (btn.GetComponentInChildren<Text>().text == "Onwards") {
            TwineTextPlayer.enabled = false;
            Time.timeScale = 1;
        }
        if (btn.GetComponentInChildren<Text>().text == "RESTART")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
