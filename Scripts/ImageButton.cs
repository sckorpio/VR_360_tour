using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageButton : MonoBehaviour 
{
	public Image IB;
	public Image IB2;
	public Text T;
	// Use this for initialization
	void Start () 
	{
		IB2.enabled = false;
		T.enabled = false;

	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void OutSide()
	{
		IB.color = Color.yellow;
		IB2.enabled = false;
		T.enabled = false;
	}

	public void Inside()
	{
		IB.color = Color.red;
		IB2.enabled = true;
		T.enabled = true;
	}
}
