using UnityEngine;
using System.Collections;
using DesignPattern_State;

public class StateTest : MonoBehaviour
{
    void Start()
    {
        UnitTest();
    }


    void UnitTest()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));

        context.Change("喜");
        context.Change("怒");
        context.Change("哀");
        context.Change("乐");
    }
}
