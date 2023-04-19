using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string _nome = "Fredy";
    [SerializeField] string _SobrbeNome;
    [SerializeField] string _NomeCompleto;
    [SerializeField] Text _text;
    void Start()
    {
        _nome = "jorge";
        _NomeCompleto = _nome + " " + "de"+ " " + _SobrbeNome;
        _text.text = _NomeCompleto; 
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
