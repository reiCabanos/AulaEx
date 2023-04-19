using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade: MonoBehaviour
{
    // Declarar 3 classes de texto
    // Implementar valor somente na primeira
    

    //Na função start
    // Alterar a 1ª variavel
    // Concatenar a 1ª e a 2ª na 3ª variavel
    

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
