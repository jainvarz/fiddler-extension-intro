using Fiddler;

[assembly: RequiredVersion("2.2.8.6")]
namespace MyFiddlerExtension
{
    public class Extension : IAutoTamper
    {
        public void AutoTamperRequestAfter(Session oSession)
        {
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            oSession.oRequest["Test-Fiddler-Extension"] = "MyTestExtension";
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnBeforeUnload()
        {
        }

        public void OnLoad()
        {
        }
    }
}
