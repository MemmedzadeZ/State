using System.Runtime.CompilerServices;

namespace Memento
{
    class Caretaker
    {
        public Memento Memento { get; set; }
   
        
    }

    class Memento
    {
        public string State { get; set; }
      
        public Memento(string state)
        {
            this.State = state;
        }
    }

    class Originator
    {
        public string? State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }

    class Program
    {
        static void Main()
        {
            Originator originator = new Originator();
            originator.State = "On";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Off";
            originator.SetMemento(caretaker.Memento);
        }
    }

}