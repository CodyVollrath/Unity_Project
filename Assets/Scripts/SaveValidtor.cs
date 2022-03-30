using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveValidtor : MonoBehaviour
{
    public void SaveProfile()
    {
        if (this.Validation())
        {
            
        }

    }

    public bool Validation()
    {
        bool valid = true;

        Text firstName = GameObject.Find("FirstNameInputText").GetComponent<Text>();
        Text lastName = GameObject.Find("LastNameInputText").GetComponent<Text>();

        Text gender = GameObject.Find("GenderInputText").GetComponent<Text>();
        Text birthday = GameObject.Find("BirthdayInputText").GetComponent<Text>();

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
