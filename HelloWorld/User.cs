namespace HelloWorld
{
    #region Classes
    public class User
    {
        
        public User()
        {    
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return user.Name.Equals(this.Name);
            }

            return false;
        }
    }
    #endregion
}
