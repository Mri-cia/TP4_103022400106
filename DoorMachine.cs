using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    internal enum State { TERKUNCI, TERBUKA };

    internal class DoorMachine
    {
        private State _currentState = State.TERKUNCI;
        public State CurrentState
        {
            get => _currentState;
            set => _currentState = value;
        }

        public DoorMachine() { }

        public void EnterDoor()
        {
            switch (CurrentState)
            {
                case State.TERKUNCI:
                    Console.WriteLine("Pintu terkunci");
                    break;
                case State.TERBUKA:
                    Console.WriteLine("Pintu tidak terkunci");
                    break; 
                default:
                    break;
            }
        }

        public void Unlock()
        {
            if (CurrentState == State.TERKUNCI) CurrentState = State.TERBUKA;
            Console.WriteLine("Membuka...");
        }

        public void Lock()
        {
            if (CurrentState == State.TERBUKA) CurrentState = State.TERKUNCI;
            Console.WriteLine("Mengunci...");
        }
    }

}
