using Assets.Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    private List<MachineEntity> optimisedMachineList = new List<MachineEntity>();
    public Text txtErrorMessage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FactoryButtonOnClick()
    {
        SceneManager.LoadScene("ReadQrCode");
    }

    public void MachineButtonOnClick()
    {
        SceneManager.LoadScene("ReadQRCode");
    }

    public void ListButtonOnClick()
    {
        if(optimisedMachineList.Count == 0)
        {
            txtErrorMessage.text = "There is No Root to Display";
        }
        else
        {
            //Display the root for machines
        }
    }
}
