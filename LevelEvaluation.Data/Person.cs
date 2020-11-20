namespace LevelEvaluation.Data
{
    /// <summary>
    /// This class represents a person's entity. It contains their name, age,
    /// country and the languages they speak. The toString() method prints
    /// how they would introduce themselves.
    /// </summary>
    public class Person
    {
        private string _name;
        private int _age;
        private string _country;
        private string[] _languages;

        // TODO: Implement a getter for the person's name
        /// <summary>
        /// This getter returns the person's name
        /// </summary>
        public string Name { get; }

        // TODO: Implement a getter for the person's age
        /// <summary>
        /// This getter returns the person's age
        /// </summary>
        public int Age { get; }

        // TODO: Implement a getter for the person's country
        /// <summary>
        /// This getter returns the person's country
        /// </summary>
        public string Country { get; }

        // TODO: Implement a constructor with a name as parameter
        /// <summary>
        /// This constructor takes a name and initializes
        /// the other fields with the following data:
        /// age: 25
        /// country: "Canada"
        /// languages: [ "English", "French" ]
        /// </summary>
        public Person(string name)
        {
            this._name = name;
            this._age = 25;
            this._country = "Canada";
            this._languages = new string[]{ "English", "French"};
        }

        // TODO: Implement a constructor with parameters for each field
        /// <summary>
        /// This constructor takes data for all fields.
        /// </summary>
        public Person(string name, int age, string country, string[] languages)
        {
            this._name = name;
            this._age = age;
            this._country = country;
            this._languages = languages;
        }

        /// <summary>
        /// This method returns a string with all the languages spoken.
        /// Ex.: languages = { "French", "Spanish", "Italian", "Japanese" }
        /// Output: French, Spanish, Italian, Japanese
        /// </summary>
        private string ListLanguages()
        {
            // TODO: Implement the following method to match the description above
            string message = "";
            int length = this._languages.Length;
            for (int i = 0; i < length - 1; i++)
                message += this._languages[i] + ",";
            message += this._languages[length - 1];
            return message;
            //throw new NotImplementedException(); // comment this line when the implementation is done
        }


        public override string ToString()
        {
            return "Hey there! My name is " + this._name + ". I am " + this._age + 
                    " years old. I speak the following languages: " + ListLanguages();
        }
    }
}
