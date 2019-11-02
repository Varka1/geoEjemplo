using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figura {


    protected float alturaTr;
    protected float baseTr;
    protected float varCirCuad;

    public Figura(float al, float bs)
    {
        alturaTr = al;
        baseTr = bs;
    }

    public Figura(float vl)
    {
        varCirCuad = vl;
    }

    public virtual void CalcularArea()
    {
        //calcula area de la figura (se sobreescribe en el hijo) 
    }

    public virtual void RenderizarObjeto()
    {
        //renderiza la figura (se sobreescribe en el hijo)   
    }
	
	
}
