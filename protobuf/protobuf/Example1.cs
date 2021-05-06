using System;
using System.IO;
using Google.Protobuf;
using Protocol.Protobuf;
using static Protocol.Protobuf.Person.Types;

namespace protobuf {
    public static class Example1 {
        public static void Run() {
            var john = new Person {
                Id = 1234,
                Name = "John Doe",
                // Email = "doe@mail.com",
                PhoneNumbers = {
                    new PhoneNumber {
                        Number = "123-4567",
                        Type = PhoneType.Home
                    }
                }
            };
            using (var output = File.Create("john_doe.dat")) {
                john.WriteTo(output);
            }

            Person newAndImprovedJohn;
            using (var input = File.OpenRead("john_doe.dat")) {
                newAndImprovedJohn = Person.Parser.ParseFrom(input);
            }

            Console.WriteLine(john);
            Console.WriteLine(newAndImprovedJohn);
            Console.WriteLine(john.Equals(newAndImprovedJohn));
        }
    }
}