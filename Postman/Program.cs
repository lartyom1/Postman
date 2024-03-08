using Postman.Classes;
using Postman.Interfaces;

namespace Postman
{
    class Program
    {
        public void Main()
        {
            Postman postman = new Postman();

            postman.UserRepository = new UserRepository();

            postman.UserRepository.AddUser(new User(0, (int)DeliveryMethod.SMS, "8911"));
            postman.UserRepository.AddUser(new User(1, (int)DeliveryMethod.Email, "@mail.com"));
            postman.UserRepository.AddUser(new User(1, 2, "@mail.com"));//non existent sender
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