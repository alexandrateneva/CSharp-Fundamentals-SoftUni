namespace Extended_Database_Problems
{
    using System;
    using System.Linq;

    public class Database
    {
        private IPerson[] people;
        private int count;

        public Database(params IPerson[] peopleByConstr)
        {
            if (peopleByConstr.Length > 5 || peopleByConstr.Length < 5)
            {
                throw new InvalidOperationException("Storing array's capacity must be exactly 5 integers.");
            }
            this.people = new IPerson[5];
            for (int i = 0; i < 5; i++)
            {
                this.people[i] = peopleByConstr[i];
            }
            this.count = 5;
        }

        public int Count => this.count;

        public void Add(IPerson person)
        {
            if (this.count >= 5)
            {
                throw new InvalidOperationException("Database is full yet.");
            }
            if (PersonExists(person.Username))
            {
                throw new InvalidOperationException("There is person with the same name yet.");
            }
            if (PersonExists(person.Id))
            {
                throw new InvalidOperationException("There is person with the same id yet.");
            }
            this.people[this.count] = person;
            this.count++;
        }

        private bool PersonExists(string username)
        {
            if (this.Count == 0)
            {
                return false;
            }

            return this.people.Where(x => x != null).Any(p => p.Username == username);
        }

        private bool PersonExists(long id)
        {
            if (this.Count == 0)
            {
                return false;
            }

            return this.people.Where(x => x != null).Any(p => p.Id == id);
        }

        public void Remove()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("Database is empty.");
            }
            this.people[this.count - 1] = default(IPerson);
            this.count--;
        }

        public IPerson[] Fetch()
        {
            var result = new IPerson[this.count];
            for (int i = 0; i < this.count; i++)
            {
                result[i] = this.people[i];
            }
            return result;
        }

        public IPerson FindByUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new NullReferenceException("Username can not be null or empty.");
            }
            if (!this.people.Any())
            {
                throw new InvalidOperationException("Data is empty.");
            }
            var person = this.people.FirstOrDefault(p => p.Username == username);
            if (person == null)
            {
                throw new InvalidOperationException("There isn't person with the same username.");
            }
            return person;
        }

        public IPerson FindById(long id)
        {
            if (id < 0)
            {
                throw new InvalidOperationException("Id can not be negative number.");
            }
            if (!this.people.Any())
            {
                throw new InvalidOperationException("Data is empty.");
            }
            var person = this.people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                throw new InvalidOperationException("There isn't person with the same id.");
            }
            return person;
        }
    }
}

