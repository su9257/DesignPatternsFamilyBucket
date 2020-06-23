using UnityEngine;
using System.Collections.Generic;

namespace DesignPattern_Observer
{

    public interface ISubject
    {
        void NotifyObservers();
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
    public class ConcreteSubject : ISubject
    {
        private IList<IObserver> observerList = new List<IObserver>();
        private string subjectState;
        public void SetState(string State)
        {
            subjectState = State;
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            for (int i = 0; i < observerList.Count; i++)
            {
                observerList[i].Update(subjectState);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }


    public interface IObserver
    {
        void Update(string state);
    }

    public class ConcreteObserver1 : IObserver
    {
        ISubject subject = null;

        public ConcreteObserver1(ISubject subject)
        {
            this.subject = subject;
        }

        public void Update(string state)
        {
            Debug.Log($"{nameof(ConcreteObserver1)}+Update:{state}");
        }
    }

    public class ConcreteObserver2 : IObserver
    {
        ISubject subject = null;

        public ConcreteObserver2(ISubject subject)
        {
            this.subject = subject;
        }

        public void Update(string state)
        {
            Debug.Log($"{nameof(ConcreteObserver2)}+Update:{state}");
        }
    }

}
