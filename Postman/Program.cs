using Postman.Classes;

namespace Postman
{
    class Program
    {
        public void Main()
        {
            Postman postman = new Postman();
            UserRepository userRepository = new UserRepository();

            userRepository.AddUser(new User(0, 0, "8911"));
            userRepository.AddUser(new User(1, 1, "@mail.com"));
            userRepository.AddUser(new User(1, 2, "@mail.com"));//non existent sender
            //etc

            List<Message> messages = new List<Message>()
            {
                new Message(0, "hello"),
                new Message(1, "howdy"),
                new Message(2, "where are u?")//non existent user
            };
            //etc


            postman.Send(messages);
        }


    }
}