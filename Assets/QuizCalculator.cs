using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Quiz Average Challenge.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Calculate the average of 5 randomly chosen quiz scores.  I decided to get
/// a little fancy with thise one.  I stored the grades in an array, then used
/// the array.Average() method from the Linq library.  Notice the using System.
/// Linq line above.
/// 
/// Things I discovered:
///    - Unity has its own Random() function.  Unless otherwise specified, the
///      one being used is UnityEngine.Random rather than System.Random.
///
/// </remarks>
/// 

public class QuizCalculator : MonoBehaviour
{
    void Start()
    {
        int[] quizScores = { Random.Range(0, 101)
                           , Random.Range(0, 101)
                           , Random.Range(0, 101)
                           , Random.Range(0, 101)
                           , Random.Range(0, 101)
                           };

        Debug.Log( "Quiz Scores: " 
                 + quizScores[0] + " - " 
                 + quizScores[1] + " - " 
                 + quizScores[2] + " - " 
                 + quizScores[3] + " - " 
                 + quizScores[4]
                 );
        double classAverage = quizScores.Average();
        Debug.Log("Average Quiz Score: " + classAverage);

        if      ( classAverage >= 90 && classAverage <= 100 ) { Debug.Log("Class average is an A"); }
        else if ( classAverage >= 80 && classAverage < 90 )   { Debug.Log("Class average is a B"); }
        else if ( classAverage >= 70 && classAverage < 80 )   { Debug.Log("Class average is a C"); }
        else if ( classAverage < 70 )                         { Debug.Log("Class is failing"); }
        else                                                  { Debug.Log("Invalid grade average."); }

    }

}
