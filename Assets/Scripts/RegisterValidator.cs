using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterValidator : MonoBehaviour
{
    public void Register(int sceneIndex)
    {
        if (this.Validation())
        {
            SceneManager.LoadScene(sceneIndex);
        }

    }

    public bool Validation()
    {
        bool valid = true;

        Text firstName = GameObject.Find("FirstNameInputText").GetComponent<Text>();
        Text lastName = GameObject.Find("LastNameInputText").GetComponent<Text>();

        Text gender = GameObject.Find("GenderInputText").GetComponent<Text>();
        Text birthday = GameObject.Find("BirthdayInputText").GetComponent<Text>();

        Text userName = GameObject.Find("UserNameInputText").GetComponent<Text>();
        Text userPassword = GameObject.Find("PasswordInputText").GetComponent<Text>();

        if (userName.text == string.Empty)
        {
            FindInActiveObjectByName("UserNameEmptyText").SetActive(true);
            valid = false;
        }
        if (userPassword.text == string.Empty)
        {
            FindInActiveObjectByName("PasswordEmptyText").SetActive(true);
            valid = false;
        }
        if (firstName.text == string.Empty)
        {
            FindInActiveObjectByName("FirstNameInvalidText").SetActive(true);
            valid = false;
        }
        if (lastName.text == string.Empty)
        {
            FindInActiveObjectByName("LastNameInvalidText").SetActive(true);
            valid = false;
        }
        if (gender.text == string.Empty)
        {
            FindInActiveObjectByName("InvalidGenderText").SetActive(true);
            valid = false;
        }
        if (birthday.text == string.Empty)
        {
            FindInActiveObjectByName("InvalidBirthdayText").SetActive(true);
            valid = false;
        }
        return valid;
    }

    private GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objects = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].hideFlags == HideFlags.None)
            {
                if (objects[i].name == name)
                {
                    return objects[i].gameObject;
                }
            }
        }
        return null;
    }
}
