using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceRegion : MonoBehaviour
{
    public Attack Attack;//обращение к другому скрипту, который привязан на кнопку
    public Sprite Region;//создаем спрайт, который будет перенимать значение спрайта из обьекта на котором находиться
    [SerializeField] private GameObject _buttonattack;//обьект кнопка
    private void OnMouseUp()//функция, которая вызывается, когда пользователь нажимает и отпускает кнопку мыши на этом обьекте
    {
        if (Attack.Isactiveattack != true)//Проверка нажата ли кнопка
        {
            Region = GetComponent<SpriteRenderer>().sprite; //Если не нажата кнопка то, спрайт Region получит значение свойства sprite от обьекта на котором находиться скрипт
            _buttonattack.SetActive(true);//Активируют(делает видимым на экране) кнопку "захватить"
        }
    }
}
