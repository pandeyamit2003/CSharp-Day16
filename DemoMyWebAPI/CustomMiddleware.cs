namespace DemoMyWebAPI
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _Next;

        public CustomMiddleware(RequestDelegate next)
        {
            _Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Request recieved...!!!");

            await _Next(context);

            Console.WriteLine("Response Sent...!!");


        }

    }
}

