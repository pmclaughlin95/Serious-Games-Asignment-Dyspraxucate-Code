using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
public class ChoiceManager : MonoBehaviour
{
    public  Question[] Questions;
    private static List<Question> unAnsweredQuestions;
    private static Question current =new Question();
    public  int score;
    [SerializeField]
    private Text questionText;

     void Start()
    {
       if(unAnsweredQuestions == null || unAnsweredQuestions.Count == 0)
        {
            unAnsweredQuestions = Questions.ToList<Question>();
        }
        SetCurrentQuestion();
    }

    void SetCurrentQuestion()
    {
        int questionIndex = Random.Range(0, unAnsweredQuestions.Count);
        current = unAnsweredQuestions[questionIndex];


        
    }
  
    public void Answer1()
    {
        if (current.answer1IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer2()
    {
        if (current.answer2IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer3()
    {
        if (current.answer3IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer4()
    {
        if (current.answer4IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer5()
    {
        if (current.answer5IsCorrect )
        {
            score++;
            Debug.Log("Score: " +score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer6()
    {
        if (current.answer6IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer7()
    {
        if (current.answer7IsCorrect)
        {
            score++;
            Debug.Log(score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer8()
    {
        if (current.answer8IsCorrect )
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer9()
    {
        if (current.answer9IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    } 
    public void Answer10()
    {
        if (current.answer10IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);

        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void Answer11()
    {
        if (current.answer11IsCorrect)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    public void SceneLoad(string LoadLevel)
    {
        if (score >= 4)
        {
            PlayerPrefs.SetString("Level1_scene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(LoadLevel);
            
        }

        
    }
 

}

