using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour {
	
	public InputField  UserNameInputField;
	public InputField  UserPasswordInputField;

	private string userName = "yufu";
	private string userPassword = "123456";

	public void Login()
	{
		if (UserNameInputField.text == userName && UserPasswordInputField.text == userPassword) {
			//load scene
			Debug.Log ("Login Success");
			Application.LoadLevel("PlayerScene");
		} else {
			Debug.Log ("Login Faild");
		}

	}
}
