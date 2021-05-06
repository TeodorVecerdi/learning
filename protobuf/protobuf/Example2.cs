using System;
using System.IO;
using Protocol.Protobuf;

namespace protobuf {
    public static class Example2 {
        public static void Run() {
            Person john;
            using (var input = File.OpenRead("john_doe.dat")) {
                john = Person.Parser.ParseFrom(input);
            }

            john.Address = "Some street";
            Console.WriteLine(john);
        }
    }
}