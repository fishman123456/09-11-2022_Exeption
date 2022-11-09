
    internal class student
    {
        string _name;
        string _fname;
        byte _age;

       
        public student (string name, string fname, byte age)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            this._name = name;
            if (fname == null)
                throw new ArgumentNullException(nameof(fname));
            this._fname = fname;
            if (age == null)
                throw new ArgumentNullException(nameof(age));
            this._age = age;
        }
        public override string ToString()
        {
            return $"Фамилия{this._fname}, имя {this._name}, возраст {this._age}";
        }

    }

