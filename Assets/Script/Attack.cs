using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool Isactiveattack;//создаем поле проверяющее, нажата ли кнопка "захватить" или нет

   [SerializeField] private GameObject _textgoalattack;// создаем поля, к которому будем привзяыват текст "выберите цель"
    private void OnMouseUp()//функция, которая вызывается, когда пользователь нажимает и отпускает кнопку мыши на этом обьекте
    {
        Isactiveattack = true; //даём буливаривоему полю значение true т.к нажали на кнопку
        _textgoalattack.SetActive(true);//включаем текст
    }
}
