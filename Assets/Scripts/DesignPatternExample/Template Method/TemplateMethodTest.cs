using UnityEngine;
using System.Collections;
using DesignPattern_TemplateMethod;

public class TemplateMethodTest : MonoBehaviour
{


    void Start()
    {
        UnitTest();
    }


    void UnitTest()
    {
        Template template = new ConcreteTemplate();
        template.TemplateMethod();
    }
}
