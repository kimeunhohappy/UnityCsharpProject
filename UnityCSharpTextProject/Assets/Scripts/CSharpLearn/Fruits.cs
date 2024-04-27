using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Goods
{
    protected virtual void Start()
    {
        nametext.text = $"과일의 이름 : {name}";
        descriptiontext.text = $"상품설명 : {description}";
        pricetext.text = $" 과일 가격 : {price}";
    }
}