using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade: MonoBehaviour
{
    // Declarar 3 classes de texto
    // Implementar valor somente na primeira
    

    //Na fun��o start
    // Alterar a 1� variavel
    // Concatenar a 1� e a 2� na 3� variavel
    

    [SerializeField] string _silaba1 = "Bo";
    [SerializeField] string _silaba2;
    [SerializeField] string _palavra;

    void Start()
    {
        _silaba1 = "ta";
        _palavra = _silaba1 + _silaba2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
