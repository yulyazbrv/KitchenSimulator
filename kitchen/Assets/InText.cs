using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InText : MonoBehaviour
{

    [SerializeField]
    private Text message;               //ОБЪЕКТНАЯ ПЕРЕМЕННАЯ ТИПА TEXT  
    public GameObject comf;
    public GameObject duh;
    public GameObject tar;
    public GameObject shkaf;
    public GameObject fridge;

    public Material mduh;
    public Material mcomf;
    public Material mtar;
    public Material mshkaf;
    public Material mfr;

    public void OnSettings()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }
    public void OnExit()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ
        message.text = "Кухня";
    }
    public void ChangComfCPU()
    {
        comf.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangComf1CPU()
    {
        comf.GetComponent<Renderer>().material = mcomf;
    }
    public void ChangColDuh()
    {
        duh.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Duh()
    {
        duh.GetComponent<Renderer>().material = mduh;
    }
    public void ChangColTar()
    {
        tar.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Tar()
    {
        tar.GetComponent<Renderer>().material = mtar;
    }
    public void ChangColShkaf()
    {
        shkaf.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangColShkaf1()
    {
        shkaf.GetComponent<Renderer>().material = mshkaf;
    }
    public void ChangColFr()
    {
        fridge.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangColFr1()
    {
        fridge.GetComponent<Renderer>().material = mfr;
    }



}
