namespace CSharp
{
    internal class encapsulation
    {
        private string name;
        private int age ;
        //public string name { get; set; }
        //public int age { get; set; }
        public string getname()
        { return name; }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getage() { return age; }
        public void setage(int age)
        {
            this.age = age;
        }




    }
}
