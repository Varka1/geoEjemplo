using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : Figura {

    private float altura;
    private float baseT;
    private float area;

    public Triangulo(float al, float bs) : base(al, bs)
    {
        altura = al;
        baseT = bs;
    }

    public override void CalcularArea()
    {
        area = ((altura * baseT) / 2);
        Debug.Log("el área del triangulo corresponde a: " + area);
    }

    public override void RenderizarObjeto(){
        //aquí va el método de renderizar objeto
    }


}
