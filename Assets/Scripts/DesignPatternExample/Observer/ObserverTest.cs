using UnityEngine;
using System.Collections;
using DesignPattern_Observer;

public class ObserverTest : MonoBehaviour
{

    void Start()
    {
        ConcreteSubject subject = new ConcreteSubject();

        ConcreteObserver1 theObserver1 = new ConcreteObserver1(subject);
        subject.RegisterObserver(theObserver1);
        subject.RegisterObserver(new ConcreteObserver2(subject));

        subject.SetState("发布订阅");
    }

}
