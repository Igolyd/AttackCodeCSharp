using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureGoal : MonoBehaviour
{
    public Attack Attack;//обращение к другому скрипту, который привязан на кнопку
    public InterfaceRegion InterfaceRegion;//обращение к другому скрипту, который привязан на "зелёный квадрат"

    public void OnMouseUp()//функция, которая вызывается, когда пользователь нажимает и отпускает кнопку мыши на этом обьекте
    {
        if(Attack.Isactiveattack == true)//проверка нажата ли кнопка "Захватить"
        {
            GetComponent<SpriteRenderer>().sprite = InterfaceRegion.Region;//спрайт, который распологается на "красном квадрате" берёт спрайт "зелёного квадрата"
        }
    }
}
