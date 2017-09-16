namespace _7.Pet_Clinics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Clinic : IEnumerable<string>
    {
        private int rooms;

        public string Name { get; private set; }
        public string[] RoomsАsArray { get; private set; }

        public Clinic(string name, int rooms)
        {
            this.RoomsАsArray = new string[rooms];
            this.Name = name;
            this.Rooms = rooms;
        }
        
        public int Rooms
        {
            get { return this.rooms; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                this.rooms = value;
            }
        }
        
        public bool Add(string nameOfPet)
        {
            var index = this.rooms / 2;
            for (int i = 0; i < this.rooms; i++)
            {
                if (i != 0 && i % 2 != 0)
                {
                    index -= i;
                }
                else if (i != 0 && i % 2 == 0)
                {
                    index += i;
                }

                if (this.RoomsАsArray[index] == null)
                {
                    this.RoomsАsArray[index] = nameOfPet;
                    return true;
                }
            }
            return false;
        }

        public bool Release()
        {
            var middle = this.rooms / 2;
            for (int i = middle; i < this.rooms; i++)
            {
                if (this.RoomsАsArray[i] != null)
                {
                    this.RoomsАsArray[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < middle; i++)
            {
                if (this.RoomsАsArray[i] != null)
                {
                    this.RoomsАsArray[i] = null;
                    return true;
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            if (this.RoomsАsArray.Any(r => r == null))
            {
                return true;
            }
            return false;
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < this.rooms; i++)
            {
                yield return this.RoomsАsArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
