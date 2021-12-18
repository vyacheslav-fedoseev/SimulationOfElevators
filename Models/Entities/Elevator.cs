using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public enum Direction { Up = 0, Down = 1, Stop = 2 }
    public class Elevator : PlaceInfo
    {
        public int CurrentFloor { get; set; }
        public bool[] DestinationFloor { get; set; }
        public bool IsOpenDoor { get; set; }
        public Direction Direction { get; set; }
        public float MaxAcceleration { get; private set; }
        public float MaxSpeed { get; private set; }
        public float Speed { get; set; }
        public float Position { get; set; }
        public float StartMovingPosition { get; set; }
        public int MaxCapacity { get; set; }
        public int LoadingTimer { get; set; }
        public int UnLoadingTimer { get; set; }
        public float StartMovingTime { get; set; }
        public float MovingTime { get; set; }



        public Elevator(float maxAcceleration, float maxSpeed, int maxCapacity, int id)
        {
            MaxAcceleration = maxAcceleration;
            MaxSpeed = maxSpeed;
            MaxCapacity = maxCapacity;
            Id = id;
            Speed = 0;
            Position = 0;
            StartMovingPosition = 0;
            Direction = Direction.Stop;
            DestinationFloor = new bool[ConfigurationData.CountFloors];
            StartMovingTime = 0;
            MovingTime = 0;
            CountPeople = 0;
            for (var i = 0; i < ConfigurationData.CountFloors; i++) DestinationFloor[i] = false;
            CurrentFloor = 1;

        }

    }
}