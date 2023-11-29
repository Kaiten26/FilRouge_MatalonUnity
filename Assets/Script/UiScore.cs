using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScore : MonoBehaviour
{

    [SerializeField] private TMP_Text _scoreTexte;

    private void OnEnable()
    {
        ScoreDatas.OnUpdate += MiseEnFormeScore;
    }

    private void OnDisable()
    {
        ScoreDatas.OnUpdate -= MiseEnFormeScore;
    }

    public void MiseEnFormeScore(int scoreValue)
    {
        _scoreTexte.text = scoreValue.ToString();
    }

}
