using UnityEngine;
using System.Collections;
using DesignPattern_Mediator;

public class MediatorTest : MonoBehaviour
{

    void Start()
    {
        ConcreteMediator mediator = new ConcreteMediator();

        ConcreateGroup0 group0 = new ConcreateGroup0(mediator);
        ConcreateGroup1 group1 = new ConcreateGroup1(mediator);

        mediator.SetColleageu1(group0);
        mediator.SetColleageu2(group1);

        group0.Action();
        group1.Action();
    }

}
