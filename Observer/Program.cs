using System.Collections;
using System;

abstract class Subject
{
    ArrayList observers = new ArrayList();
    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }
 

}

abstract class Observer
{
    public abstract void Update(string state);
}

class ConcreteObserver : Observer
{
    string name;
    ConcreteSubject subject;
    
    public override void Update(string state)
    {
        name = state;
    }
}

class ConcreteSubject : Subject
{
    private string subjectState;

   
 
}