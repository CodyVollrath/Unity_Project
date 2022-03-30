using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void LoadByIndex(int sceneIndex)
    {
        if (this.Validation())
        {
            SceneManager.LoadScene(sceneIndex);
        }
        
    }

    public bool Validation()
    {
        bool valid = true;
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
