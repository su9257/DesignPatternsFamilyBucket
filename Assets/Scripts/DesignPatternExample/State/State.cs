using UnityEngine;

namespace DesignPattern_State
{

    public class Context
    {
        State state = null;

        public void Change(string value)
        {
            state.Handle(value);
        }

        public void SetState(State theState)
        {
            state = theState;
        }
    }

    public abstract class State
    {
        protected Context context = null;

        public State(Context context)
        {
            this.context = context;
        }
        public abstract void Handle(string value);
    }
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context context) : base(context)
        { }

        public override void Handle(string value)
        {
            Debug.Log("ConcreteStateA.Handle");
            if (value == "喜")
                context.SetState(new ConcreteStateB(context));
        }

    }
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context)
        { }

        public override void Handle(string value)
        {
            Debug.Log("ConcreteStateB.Handle");
            if (value == "喜")
                context.SetState(new ConcreteStateC(context));
        }

    }
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context)
        { }

        public override void Handle(string value)
        {
            Debug.Log("ConcreteStateC.Handle");
            if (value == "喜")
                context.SetState(new ConcreteStateA(context));
        }
    }
    public class ConcreteStateD : State
    {
        public ConcreteStateD(Context context) : base(context)
        { }

        public override void Handle(string value)
        {
            Debug.Log("ConcreteStateC.Handle");
            if (value == "乐")
                context.SetState(new ConcreteStateA(context));
        }
    }

}