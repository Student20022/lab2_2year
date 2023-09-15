using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternss
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int state;

        public int State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyObservers();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    public interface IObserver
    {
        void Update();
    }

    public class ConcreteObserver : IObserver
    {
        private string name;
        private Subject subject;

        public ConcreteObserver(string name, Subject subject)
        {
            this.name = name;
            this.subject = subject;
            subject.Attach(this);
        }

        public void Update()
        {
            MessageBox.Show($"{name} получил обновление: {subject.State}");
        }
    }
}