using Postman.Classes;
using Postman.Interfaces;

namespace Postman
{
    class Program
    {
        public static void Main()
        {
            Postman postman = new Postman();

            postman.AddUser(new User("0", (int)DeliveryMethod.SMS, "8911"));
            postman.AddUser(new User("1", (int)DeliveryMethod.Email, "@mail.com"));
            postman.AddUser(new User("2", 2, "@mail.com"));//non existent sender
            //etc

            List<Message> messages = new List<Message>()
            {
                new Message(0, "hello"),

                new Message(0, "hello2"),
                new Message(0, "hello3"),
                new Message(0, "hello4"),
                new Message(0, "hello5"),
                new Message(0, "hello6"),
                new Message(0, "hello7"),
                new Message(0, "hello8"),

                new Message(1, "howdy"),

                new Message(1, "howdy2"),
                new Message(1, "howdy3"),
                new Message(1, "howdy4"),
                new Message(1, "howdy5"),
                new Message(1, "howdy6"),
                new Message(1, "howdy7"),
                new Message(1, "howdy8"),

                new Message(3, "where are u?")//non existent user
            };
            //etc


            postman.Send(messages);
        }


    }
}