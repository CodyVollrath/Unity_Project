using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerValidtor : MonoBehaviour
{
    public void Answer(int sceneIndex)
    {
        if (this.Validation())
        {
            SceneManager.LoadScene(sceneIndex);
        }

    }

    public bool Validation()
    {
        bool valid = true;

        Text answer = GameObject.Find("AnswerInputText").GetComponent<Text>();

        if (answer.text == string.Empty)
        {
            FindInActiveObjectByName("AnswerEmptyText").SetActive(true);
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
