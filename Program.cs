using Door;

var Pos = new KodePos();

Pos.GetKodePos();

Console.WriteLine();

Door.DoorMachine pintu1 = new();

pintu1.EnterDoor();
pintu1.Lock();
pintu1.EnterDoor();
pintu1.Unlock();
pintu1.EnterDoor();
pintu1.Unlock();
pintu1.EnterDoor();
pintu1.Lock();
pintu1.EnterDoor();