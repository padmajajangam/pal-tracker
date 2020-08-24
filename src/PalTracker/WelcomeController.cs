using Microsoft.AspNetCore.Mvc;


namespace PalTracker
{
    
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        WelcomeMessage _message;
        public WelcomeController(WelcomeMessage welcomeMessage)
        {
            _message = welcomeMessage;
            
        }

        [HttpGet]
        public string SayHello() => _message.Message;
    }
}