using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {
            Message message = new()
            {
                Text = "Hello there!",
                From = null,
            };

            MessagePopulator.Populate(message); // idk it wasn't explained properly

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "no from");
            Console.WriteLine(message.From!.Length);
            Console.WriteLine(message.ToUpperFrom());
        }
    }
}
